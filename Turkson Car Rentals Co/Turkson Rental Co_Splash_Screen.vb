Public Class Turkson_Rental_Co_Splash_Screen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Turkson_Rental_Co_Splash_Screen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles pbSplashScreen.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'pbSplashScreen.Increment(1)
        If pbSplashScreen.Value = 100 Then
            pbSplashScreen.Increment(2)
            frmUserLogin.Show()
            Me.Hide()
            'Me.Close()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

