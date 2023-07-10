<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MesajAlertUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Animasyon_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Alert_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Animasyon_Timer
        '
        Me.Animasyon_Timer.Interval = 1000
        '
        'Alert_Label
        '
        Me.Alert_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Alert_Label.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Alert_Label.ForeColor = System.Drawing.Color.White
        Me.Alert_Label.Location = New System.Drawing.Point(7, 13)
        Me.Alert_Label.Name = "Alert_Label"
        Me.Alert_Label.Size = New System.Drawing.Size(451, 33)
        Me.Alert_Label.TabIndex = 1095
        Me.Alert_Label.Text = "---"
        Me.Alert_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MesajAlertUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.Controls.Add(Me.Alert_Label)
        Me.Name = "MesajAlertUser"
        Me.Size = New System.Drawing.Size(467, 58)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Animasyon_Timer As System.Windows.Forms.Timer
    Friend WithEvents Alert_Label As System.Windows.Forms.Label
End Class
