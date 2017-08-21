'Nicholas Brooks Project 9
Imports System.Windows.Forms
Imports NBrooks_Project9.GenericLinearSearch

Public Class genericSearchForm
    Private randInts(9) As Integer 'int array
    Private randDoubles(9) As Double 'double array
    Dim lowerBound As Double = 0.00 'boundries for random num generators
    Dim upperBound As Double = 999.0 'boundries for random num generators
    Dim listFormat As String = String.Empty 'string variable for listbox
    Dim intArrayOn As Boolean = True 'boolean switch to see what type of numbers user generated

    'Create Ints
    Private Sub btnCreateInt_Click(sender As Object, e As EventArgs) Handles btnCreateInt.Click
        searchKeyTxtBox.Text = String.Empty 'clear search txtbox
        'add generated ints to ints array
        For i = 0 To randInts.Count - 1
            randInts(i) = CInt(Math.Floor((upperBound - lowerBound + 1) * Rnd())) + lowerBound 'generate int
        Next
        intArrayOn = True 'switch on
        'display in listbox
        clearList() 'clear previous list
        displayArray()

    End Sub

    'Create Doubles
    Private Sub btnCreateDoubles_Click(sender As Object, e As EventArgs) Handles btnCreateDoubles.Click
        searchKeyTxtBox.Text = String.Empty 'clear search txtbox 
        Dim rndDouble As New Random 'random double
        Const DEC_PLACES As Integer = 2 ' decimal places

        'add generated dobules to double array
        For i = 0 To randDoubles.Count - 1
            randDoubles(i) = Math.Round(rndDouble.NextDouble() * (upperBound - lowerBound) + lowerBound, DEC_PLACES) 'generate double
        Next
        intArrayOn = False 'switch off
        'display in listbox
        clearList() 'clear previous list
        displayArray()
    End Sub

    'User Search button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim resultText As String = String.Empty 'reset result textbox
        Dim userNum As Double
        Dim keyResult As Integer
        'get userinput
        If (Double.TryParse(searchKeyTxtBox.Text, userNum)) Then
            userNum = Double.Parse(searchKeyTxtBox.Text)
            'Call search
            If (intArrayOn) Then
                keyResult = Search(randInts, userNum) 'call generic search method passing int array
            Else
                keyResult = Search(randDoubles, userNum) 'call generic search method passing double array
            End If

            'Custom message depending if value was found
            If (keyResult = -1) Then
                resultText = "Value Not Found"
            Else
                resultText = "Found value in index " & keyResult
            End If

        Else 'Display error            
            MessageBox.Show("Not a Number", "Incorrect Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            searchKeyTxtBox.Text = String.Empty 'reset textbox
            Return
        End If

        'Display Result
        resultLabel.Text = resultText
    End Sub

    'Display array
    Private Sub displayArray()
        Dim index As Integer = 0 'representing array index

        listFormat += String.Format("{0,-12}{1,-12}", "Index:", "Value:")
        numListBox.Items.Add(listFormat) 'add header

        'Determine if int or double was generated 
        If (intArrayOn) Then
            'Loop through And display INT array contents
            For Each ind In randInts
                numListBox.Items.Add(String.Format("{0,-15}{1,-12}", index.ToString, ind.ToString))
                index += 1 'increment index
            Next
        Else
            'Loop through And display DOUBLE array contents
            For Each ind In randDoubles
                numListBox.Items.Add(String.Format("{0,-15}{1,-12}", index.ToString, ind.ToString))
                index += 1 'increment index
            Next
        End If
    End Sub

    'Clear list box
    Private Sub clearList()
        listFormat = String.Empty
        numListBox.Items.Clear()
    End Sub

End Class
