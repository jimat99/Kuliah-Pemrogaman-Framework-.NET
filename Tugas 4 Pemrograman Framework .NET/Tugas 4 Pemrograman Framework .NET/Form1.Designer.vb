<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bgWorkerFaktor = New System.ComponentModel.BackgroundWorker()
        Me.bgWorkerKelipatan = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textAngkaFaktor = New System.Windows.Forms.TextBox()
        Me.buttonCariFaktor = New System.Windows.Forms.Button()
        Me.listBoxFaktor = New System.Windows.Forms.ListBox()
        Me.progressBarFaktor = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textAngkaKelipatan = New System.Windows.Forms.TextBox()
        Me.textBatasAkhirKelipatan = New System.Windows.Forms.TextBox()
        Me.textBatasAwalKelipatan = New System.Windows.Forms.TextBox()
        Me.buttonCariKelipatan = New System.Windows.Forms.Button()
        Me.listBoxKelipatan = New System.Windows.Forms.ListBox()
        Me.progressBarKelipatan = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Pencari Faktor dan Kelipatan Bilangan"
        '
        'bgWorkerFaktor
        '
        Me.bgWorkerFaktor.WorkerReportsProgress = True
        Me.bgWorkerFaktor.WorkerSupportsCancellation = True
        '
        'bgWorkerKelipatan
        '
        Me.bgWorkerKelipatan.WorkerReportsProgress = True
        Me.bgWorkerKelipatan.WorkerSupportsCancellation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Faktor"
        '
        'textAngkaFaktor
        '
        Me.textAngkaFaktor.Location = New System.Drawing.Point(96, 115)
        Me.textAngkaFaktor.Name = "textAngkaFaktor"
        Me.textAngkaFaktor.Size = New System.Drawing.Size(100, 20)
        Me.textAngkaFaktor.TabIndex = 2
        '
        'buttonCariFaktor
        '
        Me.buttonCariFaktor.Location = New System.Drawing.Point(106, 141)
        Me.buttonCariFaktor.Name = "buttonCariFaktor"
        Me.buttonCariFaktor.Size = New System.Drawing.Size(75, 23)
        Me.buttonCariFaktor.TabIndex = 3
        Me.buttonCariFaktor.Text = "Cari Faktor"
        Me.buttonCariFaktor.UseVisualStyleBackColor = True
        '
        'listBoxFaktor
        '
        Me.listBoxFaktor.FormattingEnabled = True
        Me.listBoxFaktor.Location = New System.Drawing.Point(24, 170)
        Me.listBoxFaktor.Name = "listBoxFaktor"
        Me.listBoxFaktor.Size = New System.Drawing.Size(251, 173)
        Me.listBoxFaktor.TabIndex = 4
        '
        'progressBarFaktor
        '
        Me.progressBarFaktor.Location = New System.Drawing.Point(71, 349)
        Me.progressBarFaktor.Name = "progressBarFaktor"
        Me.progressBarFaktor.Size = New System.Drawing.Size(153, 23)
        Me.progressBarFaktor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Angka Kelipatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(595, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Batas Akhir Kelipatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Batas Awal Kelipatan"
        '
        'textAngkaKelipatan
        '
        Me.textAngkaKelipatan.Location = New System.Drawing.Point(512, 115)
        Me.textAngkaKelipatan.Name = "textAngkaKelipatan"
        Me.textAngkaKelipatan.Size = New System.Drawing.Size(100, 20)
        Me.textAngkaKelipatan.TabIndex = 9
        '
        'textBatasAkhirKelipatan
        '
        Me.textBatasAkhirKelipatan.Location = New System.Drawing.Point(598, 170)
        Me.textBatasAkhirKelipatan.Name = "textBatasAkhirKelipatan"
        Me.textBatasAkhirKelipatan.Size = New System.Drawing.Size(100, 20)
        Me.textBatasAkhirKelipatan.TabIndex = 10
        '
        'textBatasAwalKelipatan
        '
        Me.textBatasAwalKelipatan.Location = New System.Drawing.Point(412, 170)
        Me.textBatasAwalKelipatan.Name = "textBatasAwalKelipatan"
        Me.textBatasAwalKelipatan.Size = New System.Drawing.Size(100, 20)
        Me.textBatasAwalKelipatan.TabIndex = 11
        '
        'buttonCariKelipatan
        '
        Me.buttonCariKelipatan.Location = New System.Drawing.Point(495, 202)
        Me.buttonCariKelipatan.Name = "buttonCariKelipatan"
        Me.buttonCariKelipatan.Size = New System.Drawing.Size(117, 23)
        Me.buttonCariKelipatan.TabIndex = 12
        Me.buttonCariKelipatan.Text = "Cari Kelipatan"
        Me.buttonCariKelipatan.UseVisualStyleBackColor = True
        '
        'listBoxKelipatan
        '
        Me.listBoxKelipatan.FormattingEnabled = True
        Me.listBoxKelipatan.Location = New System.Drawing.Point(427, 231)
        Me.listBoxKelipatan.Name = "listBoxKelipatan"
        Me.listBoxKelipatan.Size = New System.Drawing.Size(251, 173)
        Me.listBoxKelipatan.TabIndex = 13
        '
        'progressBarKelipatan
        '
        Me.progressBarKelipatan.Location = New System.Drawing.Point(486, 410)
        Me.progressBarKelipatan.Name = "progressBarKelipatan"
        Me.progressBarKelipatan.Size = New System.Drawing.Size(153, 23)
        Me.progressBarKelipatan.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 450)
        Me.Controls.Add(Me.progressBarKelipatan)
        Me.Controls.Add(Me.listBoxKelipatan)
        Me.Controls.Add(Me.buttonCariKelipatan)
        Me.Controls.Add(Me.textBatasAwalKelipatan)
        Me.Controls.Add(Me.textBatasAkhirKelipatan)
        Me.Controls.Add(Me.textAngkaKelipatan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.progressBarFaktor)
        Me.Controls.Add(Me.listBoxFaktor)
        Me.Controls.Add(Me.buttonCariFaktor)
        Me.Controls.Add(Me.textAngkaFaktor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bgWorkerFaktor As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgWorkerKelipatan As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents textAngkaFaktor As TextBox
    Friend WithEvents buttonCariFaktor As Button
    Friend WithEvents listBoxFaktor As ListBox
    Friend WithEvents progressBarFaktor As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textAngkaKelipatan As TextBox
    Friend WithEvents textBatasAkhirKelipatan As TextBox
    Friend WithEvents textBatasAwalKelipatan As TextBox
    Friend WithEvents buttonCariKelipatan As Button
    Friend WithEvents listBoxKelipatan As ListBox
    Friend WithEvents progressBarKelipatan As ProgressBar
End Class
