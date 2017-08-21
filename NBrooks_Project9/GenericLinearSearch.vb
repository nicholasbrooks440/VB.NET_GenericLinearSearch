Public Class GenericLinearSearch

    'Generic Method Search
    Public Shared Function Search(Of T As IComparable(Of T)) _
      (inputArray() As T, userInput As T) As Integer

        Dim key As Integer = -1 'default value
        Dim index As Integer = 0 'representing array index
        For Each element In inputArray

            If (element.CompareTo(userInput) = 0) Then 'Match was found: Pg.29
                'change value of the key to the current element
                'key = Int32.Parse(inputArray.IndexOf(inputArray, userInput)) 'another way of getting index
                key = index
                Exit For 'exit for each loop
            End If

            index += 1 'increment index
        Next

        Return key

    End Function
End Class
