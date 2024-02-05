'Jason Graham
'1/6/2020
'A simple game of Tetris
Public Class Form1
    Const ROW As Byte = 20
    Const COL As Byte = 11

    Dim rand As New Random

    Dim board(ROW, COL) As aSquare

    Dim currentPiece(3) As aPiece
    Dim bytpiece As Byte
    Dim bytnext As Byte
    Dim sturncount As Byte

    Dim blnendturn As Boolean
    Dim blngameover As Boolean = True

    Dim bytturncount As Byte
    Dim bytrotation As Byte

    Dim shtscore As Short

    Structure aSquare
        Dim b As Rectangle
        Dim c As Byte
    End Structure

    Structure aPiece
        Dim l As Point
        Dim n As Boolean
        Dim color As Byte
    End Structure

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If blngameover = False Then
            If e.KeyCode = Keys.Left Then moveHorizontal(-1)
            If e.KeyCode = Keys.Right Then moveHorizontal(1)

            If e.KeyCode = Keys.Down Then
                tmrpiece.Enabled = False
                tmrfastdown.Enabled = True

            End If

            If e.KeyCode = Keys.Up Then
                Turn()
            End If

            Me.Refresh()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If blngameover = False Then
            If e.KeyCode = Keys.Down Then
                tmrfastdown.Enabled = False
                tmrpiece.Enabled = True
            End If
        End If
    End Sub

    Private Sub moveHorizontal(ByRef bytdirect As SByte)
        For i = 0 To currentPiece.Length - 1
            currentPiece(i).n = False

            For u = 0 To currentPiece.Length - 1
                If currentPiece(i).l.X = currentPiece(u).l.X And currentPiece(i).l.Y + bytdirect = currentPiece(u).l.Y Then currentPiece(i).n = True
            Next
        Next

        For i = 0 To currentPiece.Length - 1
            If currentPiece(i).n = False Then
                If board(currentPiece(i).l.X, currentPiece(i).l.Y + bytdirect).c <> 0 Then Exit Sub
            End If
        Next

        For i = 0 To currentPiece.Length - 1
            board(currentPiece(i).l.X, currentPiece(i).l.Y).c = 0
        Next

        For i = 0 To currentPiece.Length - 1

            currentPiece(i).l = New Point(currentPiece(i).l.X, currentPiece(i).l.Y + bytdirect)

            board(currentPiece(i).l.X, currentPiece(i).l.Y).c = currentPiece(i).color

        Next

    End Sub

    Private Sub Start()
        Me.DoubleBuffered = True
        tmrpiece.Enabled = True
        blngameover = False
        Me.Focus()

        Dim xspot, yspot As Short
        xspot = 20
        yspot = 20

        'make board
        For r = 0 To ROW
            For c = 0 To COL
                board(r, c).b = New Rectangle(xspot, yspot, 40, 40)
                xspot += 45

            Next
            yspot += 45
            xspot = 20
        Next

        For i = 0 To COL
            board(20, i).c = 1
        Next

        For i = 0 To ROW - 1
            board(i, 0).c = 1
            board(i, COL).c = 1
        Next

        bytnext = rand.Next(0, 7)

        getPiece()
    End Sub

    Private Sub showNext()
        If bytnext = 0 Then
            pctnext.Image = My.Resources.T

        ElseIf bytnext = 1 Then
            pctnext.Image = My.Resources.straight

        ElseIf bytnext = 2 Then
            pctnext.Image = My.Resources.Square_svg

        ElseIf bytnext = 3 Then
            pctnext.Image = My.Resources.J

        ElseIf bytnext = 4 Then
            pctnext.Image = My.Resources.L_svg

        ElseIf bytnext = 5 Then
            pctnext.Image = My.Resources.Z

        Else
            pctnext.Image = My.Resources.S

        End If
    End Sub

    Private Sub getPiece()
        Dim bytnew As Byte = bytnext
        Dim bytexclude As Byte = 10

        bytturncount = 0

        If bytpiece = bytnext Then
            bytexclude = bytpiece

        End If

        bytpiece = bytnext

        Do
            bytnext = rand.Next(0, 7)
        Loop While bytexclude = bytnext

        showNext()

        If bytpiece = 0 Then 'T Block
            currentPiece(0).l = New Point(0, 5)
            currentPiece(1).l = New Point(1, 5)
            currentPiece(2).l = New Point(2, 5)
            currentPiece(3).l = New Point(1, 6)

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).color = 1
            Next

        ElseIf bytpiece = 1 Then 'I Block
            currentPiece(0).l = New Point(0, 5)
            currentPiece(1).l = New Point(1, 5)
            currentPiece(2).l = New Point(2, 5)
            currentPiece(3).l = New Point(3, 5)

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).color = 2
            Next

        ElseIf bytpiece = 2 Then 'Square
            currentPiece(0).l = New Point(0, 5)
            currentPiece(1).l = New Point(0, 6)
            currentPiece(2).l = New Point(1, 5)
            currentPiece(3).l = New Point(1, 6)

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).color = 3
            Next

        ElseIf bytpiece = 3 Then 'J Block
            currentPiece(0).l = New Point(0, 6)
            currentPiece(1).l = New Point(1, 6)
            currentPiece(2).l = New Point(2, 6)
            currentPiece(3).l = New Point(2, 5)

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).color = 4
            Next

        ElseIf bytpiece = 4 Then 'L Block
            currentPiece(0).l = New Point(0, 5)
            currentPiece(1).l = New Point(1, 5)
            currentPiece(2).l = New Point(2, 5)
            currentPiece(3).l = New Point(2, 6)

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).color = 5
            Next

        ElseIf bytpiece = 5 Then 'Z Block
            currentPiece(0).l = New Point(0, 6)
            currentPiece(1).l = New Point(1, 6)
            currentPiece(2).l = New Point(1, 5)
            currentPiece(3).l = New Point(2, 5)

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).color = 6
            Next

        Else 'S Block
            currentPiece(0).l = New Point(0, 5)
            currentPiece(1).l = New Point(1, 5)
            currentPiece(2).l = New Point(1, 6)
            currentPiece(3).l = New Point(2, 6)

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).color = 7
            Next

        End If



        For i = 0 To currentPiece.Length - 1
            board(currentPiece(i).l.X, currentPiece(i).l.Y).c = currentPiece(i).color
        Next


    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        For r = 0 To ROW - 1
            For c = 1 To COL - 1
                If board(r, c).c = 0 Then
                    e.Graphics.FillRectangle(Brushes.Gray, board(r, c).b)
                ElseIf board(r, c).c = 1 Then
                    e.Graphics.FillRectangle(Brushes.Purple, board(r, c).b)
                ElseIf board(r, c).c = 2 Then
                    e.Graphics.FillRectangle(Brushes.Blue, board(r, c).b)
                ElseIf board(r, c).c = 3 Then
                    e.Graphics.FillRectangle(Brushes.Yellow, board(r, c).b)
                ElseIf board(r, c).c = 4 Then
                    e.Graphics.FillRectangle(Brushes.DarkBlue, board(r, c).b)
                ElseIf board(r, c).c = 5 Then
                    e.Graphics.FillRectangle(Brushes.Orange, board(r, c).b)
                ElseIf board(r, c).c = 6 Then
                    e.Graphics.FillRectangle(Brushes.Red, board(r, c).b)
                Else
                    e.Graphics.FillRectangle(Brushes.Lime, board(r, c).b)
                End If
            Next
        Next
    End Sub

    Private Sub tmrpiece_Tick(sender As Object, e As EventArgs) Handles tmrpiece.Tick

        Down()

        Me.Refresh()
    End Sub

    Private Sub Down()
        Dim bytconsecutiverows As Byte

        bytturncount += 1

        blnendturn = False

        'Move the pieces down
        For i = 0 To currentPiece.Length - 1
            currentPiece(i).n = False
        Next

        For j = 0 To currentPiece.Length - 1
            For k = 0 To currentPiece.Length - 1
                If currentPiece(j).l.X + 1 = currentPiece(k).l.X And currentPiece(j).l.Y = currentPiece(k).l.Y Then
                    currentPiece(j).n = True
                End If
            Next
        Next

        For i = 0 To currentPiece.Length - 1
            If currentPiece(i).n = False Then
                If board(currentPiece(i).l.X + 1, currentPiece(i).l.Y).c <> 0 Then
                    blnendturn = True
                    Exit For
                End If
            End If
        Next

        If blnendturn = False Then
            For i = 0 To currentPiece.Length - 1
                board(currentPiece(i).l.X, currentPiece(i).l.Y).c = 0

            Next

            For i = 0 To currentPiece.Length - 1
                currentPiece(i).l = New Point(currentPiece(i).l.X + 1, currentPiece(i).l.Y)

                board(currentPiece(i).l.X, currentPiece(i).l.Y).c = currentPiece(i).color
            Next

        Else
            If bytturncount = 1 Then
                Lose()

            End If
            'Check for complete line
            For r = ROW - 1 To 0 Step -1
same_line:      For c = 1 To COL - 1
                    If board(r, c).c = 0 Then
                        GoTo next_line
                    End If
                Next

                For c = 1 To COL - 1
                    board(r, c).c = 0

                Next

                For m = r - 1 To 0 Step -1
                    For c = 1 To COL - 1
                        If board(m, c).c <> 0 Then
                            board(m + 1, c).c = board(m, c).c
                            board(m, c).c = 0
                        End If
                    Next

                Next

                For i = 0 To currentPiece.Length - 1
                    currentPiece(i).l = New Point(currentPiece(i).l.X + 1, currentPiece(i).l.Y)
                Next

                bytconsecutiverows += 1

                GoTo same_line
next_line:  Next

            If bytconsecutiverows > 0 Then
                If bytconsecutiverows = 1 Or bytconsecutiverows = 2 Then
                    shtscore += 100 * bytconsecutiverows

                ElseIf bytconsecutiverows = 3 Then
                    shtscore += 400

                Else
                    shtscore += 800

                End If

                If shtscore >= 1000 Then
                    lblscore.Text = "Score: " & shtscore

                Else
                    lblscore.Text = "Score: 0" & shtscore

                End If

            End If

            getPiece()
        End If
    End Sub

    Private Sub Turn()
        If bytpiece <> 2 Then

            Dim oldpos As Point = currentPiece(1).l
            Dim dist As Point
            Dim newpoint(currentPiece.Length - 1) As Point

            For i = 0 To currentPiece.Length - 1
                newpoint(i) = currentPiece(i).l
                newpoint(i) = New Point(newpoint(i).Y, -newpoint(i).X)
            Next

            dist = New Point(newpoint(1).X - oldpos.X, newpoint(1).Y - oldpos.Y)

            For i = 0 To currentPiece.Length - 1
                newpoint(i) = New Point(newpoint(i).X - dist.X, newpoint(i).Y - dist.Y)
            Next

            For i = 0 To newpoint.Length - 1
                'Check if turning puts shape out of bounds
                If newpoint(i).Y < 1 Or newpoint(i).Y > COL - 1 Or newpoint(i).X < 1 Or newpoint(i).X > ROW - 1 Then Exit Sub

                If board(newpoint(i).X, newpoint(i).Y).c <> 0 Then
                    For j = 0 To currentPiece.Length - 1
                        If newpoint(i) = currentPiece(j).l Then GoTo valid

                    Next
                    Exit Sub
                End If
valid:      Next

            For i = 0 To currentPiece.Length - 1
                board(currentPiece(i).l.X, currentPiece(i).l.Y).c = 0
                currentPiece(i).l = newpoint(i)
            Next

            For i = 0 To currentPiece.Length - 1
                board(currentPiece(i).l.X, currentPiece(i).l.Y).c = currentPiece(i).color

            Next

            Me.Refresh()

        End If


    End Sub

    Private Sub Lose()
        tmrfastdown.Enabled = False
        tmrpiece.Enabled = False
        blngameover = True

        btnreplay.Visible = True

    End Sub

    Private Sub tmrfastdown_Tick(sender As Object, e As EventArgs) Handles tmrfastdown.Tick
        Down()
        Me.Refresh()
    End Sub

    Private Sub btnreplay_Click(sender As Object, e As EventArgs) Handles btnreplay.Click
        btnreplay.Visible = False

        shtscore = 0

        For r = ROW - 1 To 0 Step -1
            For c = 1 To COL - 1
                board(r, c).c = 0
            Next
        Next

        blngameover = False

        getPiece()
        tmrpiece.Enabled = True

        Me.Refresh()
        Me.Focus()
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        pcttitle.Visible = False
        lblcredit.Visible = False
        btnstart.Visible = False

        Start()
        Me.Refresh()
    End Sub
End Class
