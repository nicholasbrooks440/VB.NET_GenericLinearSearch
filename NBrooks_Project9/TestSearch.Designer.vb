<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class genericSearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreateInt = New System.Windows.Forms.Button()
        Me.btnCreateDoubles = New System.Windows.Forms.Button()
        Me.numListBox = New System.Windows.Forms.ListBox()
        Me.searchKeyLabel = New System.Windows.Forms.Label()
        Me.searchKeyTxtBox = New System.Windows.Forms.TextBox()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateInt
        '
        Me.btnCreateInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateInt.Location = New System.Drawing.Point(19, 12)
        Me.btnCreateInt.Name = "btnCreateInt"
        Me.btnCreateInt.Size = New System.Drawing.Size(75, 60)
        Me.btnCreateInt.TabIndex = 0
        Me.btnCreateInt.Text = "Create Integers"
        Me.btnCreateInt.UseVisualStyleBackColor = True
        '
        'btnCreateDoubles
        '
        Me.btnCreateDoubles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateDoubles.Location = New System.Drawing.Point(220, 12)
        Me.btnCreateDoubles.Name = "btnCreateDoubles"
        Me.btnCreateDoubles.Size = New System.Drawing.Size(75, 60)
        Me.btnCreateDoubles.TabIndex = 1
        Me.btnCreateDoubles.Text = "Create Doubles"
        Me.btnCreateDoubles.UseVisualStyleBackColor = True
        '
        'numListBox
        '
        Me.numListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numListBox.FormattingEnabled = True
        Me.numListBox.ItemHeight = 16
        Me.numListBox.Location = New System.Drawing.Point(19, 88)
        Me.numListBox.Name = "numListBox"
        Me.numListBox.Size = New System.Drawing.Size(276, 180)
        Me.numListBox.TabIndex = 99
        Me.numListBox.TabStop = False
        '
        'searchKeyLabel
        '
        Me.searchKeyLabel.AutoSize = True
        Me.searchKeyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchKeyLabel.Location = New System.Drawing.Point(16, 296)
        Me.searchKeyLabel.Name = "searchKeyLabel"
        Me.searchKeyLabel.Size = New System.Drawing.Size(114, 16)
        Me.searchKeyLabel.TabIndex = 3
        Me.searchKeyLabel.Text = "Enter Search Key:"
        '
        'searchKeyTxtBox
        '
        Me.searchKeyTxtBox.Location = New System.Drawing.Point(136, 293)
        Me.searchKeyTxtBox.Name = "searchKeyTxtBox"
        Me.searchKeyTxtBox.Size = New System.Drawing.Size(159, 20)
        Me.searchKeyTxtBox.TabIndex = 2
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultLabel.Location = New System.Drawing.Point(19, 359)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(276, 23)
        Me.resultLabel.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(19, 319)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(276, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'genericSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 406)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.searchKeyTxtBox)
        Me.Controls.Add(Me.searchKeyLabel)
        Me.Controls.Add(Me.numListBox)
        Me.Controls.Add(Me.btnCreateDoubles)
        Me.Controls.Add(Me.btnCreateInt)
        Me.Name = "genericSearchForm"
        Me.Text = "Brooks: Generic Linear Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateInt As Button
    Friend WithEvents btnCreateDoubles As Button
    Friend WithEvents numListBox As ListBox
    Friend WithEvents searchKeyLabel As Label
    Friend WithEvents searchKeyTxtBox As TextBox
    Friend WithEvents resultLabel As Label
    Friend WithEvents btnSearch As Button
End Class
