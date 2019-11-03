<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemoVariabel
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
        Me.lbHasil = New System.Windows.Forms.ListBox()
        Me.btHitung = New System.Windows.Forms.Button()
        Me.btKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbHasil
        '
        Me.lbHasil.FormattingEnabled = True
        Me.lbHasil.Location = New System.Drawing.Point(12, 12)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(298, 95)
        Me.lbHasil.TabIndex = 0
        '
        'btHitung
        '
        Me.btHitung.Location = New System.Drawing.Point(13, 114)
        Me.btHitung.Name = "btHitung"
        Me.btHitung.Size = New System.Drawing.Size(75, 23)
        Me.btHitung.TabIndex = 1
        Me.btHitung.Text = "Button1"
        Me.btHitung.UseVisualStyleBackColor = True
        '
        'btKeluar
        '
        Me.btKeluar.Location = New System.Drawing.Point(94, 114)
        Me.btKeluar.Name = "btKeluar"
        Me.btKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btKeluar.TabIndex = 2
        Me.btKeluar.Text = "Button2"
        Me.btKeluar.UseVisualStyleBackColor = True
        '
        'frmDemoVariabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 146)
        Me.Controls.Add(Me.btKeluar)
        Me.Controls.Add(Me.btHitung)
        Me.Controls.Add(Me.lbHasil)
        Me.Name = "frmDemoVariabel"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbHasil As ListBox
    Friend WithEvents btHitung As Button
    Friend WithEvents btKeluar As Button
End Class
