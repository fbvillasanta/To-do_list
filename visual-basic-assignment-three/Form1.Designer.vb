<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class todoForm
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
        Me.regularlist = New System.Windows.Forms.CheckedListBox()
        Me.add = New System.Windows.Forms.Button()
        Me.remove = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.prioritylist = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.todo = New System.Windows.Forms.TextBox()
        Me.isPriority = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'regularlist
        '
        Me.regularlist.CheckOnClick = True
        Me.regularlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regularlist.FormattingEnabled = True
        Me.regularlist.Location = New System.Drawing.Point(13, 146)
        Me.regularlist.Name = "regularlist"
        Me.regularlist.Size = New System.Drawing.Size(400, 79)
        Me.regularlist.TabIndex = 0
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(354, 17)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(64, 26)
        Me.add.TabIndex = 1
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'remove
        '
        Me.remove.Location = New System.Drawing.Point(75, 300)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(118, 33)
        Me.remove.TabIndex = 2
        Me.remove.Text = "Done"
        Me.remove.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(215, 300)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(118, 33)
        Me.reset.TabIndex = 3
        Me.reset.Text = "Delete All"
        Me.reset.UseVisualStyleBackColor = True
        '
        'prioritylist
        '
        Me.prioritylist.CheckOnClick = True
        Me.prioritylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prioritylist.ForeColor = System.Drawing.Color.Red
        Me.prioritylist.FormattingEnabled = True
        Me.prioritylist.Location = New System.Drawing.Point(13, 43)
        Me.prioritylist.Name = "prioritylist"
        Me.prioritylist.Size = New System.Drawing.Size(400, 72)
        Me.prioritylist.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.prioritylist)
        Me.GroupBox1.Controls.Add(Me.regularlist)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 241)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "To-Do List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(164, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Priority!"
        '
        'todo
        '
        Me.todo.Location = New System.Drawing.Point(11, 19)
        Me.todo.Name = "todo"
        Me.todo.Size = New System.Drawing.Size(271, 20)
        Me.todo.TabIndex = 6
        '
        'isPriority
        '
        Me.isPriority.AutoSize = True
        Me.isPriority.Location = New System.Drawing.Point(292, 22)
        Me.isPriority.Name = "isPriority"
        Me.isPriority.Size = New System.Drawing.Size(57, 17)
        Me.isPriority.TabIndex = 7
        Me.isPriority.Text = "Priority"
        Me.isPriority.UseVisualStyleBackColor = True
        '
        'todoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 345)
        Me.Controls.Add(Me.isPriority)
        Me.Controls.Add(Me.todo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.add)
        Me.Name = "todoForm"
        Me.Text = "To-Do Lists"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents regularlist As System.Windows.Forms.CheckedListBox
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents remove As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents prioritylist As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents todo As System.Windows.Forms.TextBox
    Friend WithEvents isPriority As System.Windows.Forms.CheckBox

End Class
