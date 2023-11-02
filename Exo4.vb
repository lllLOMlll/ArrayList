Imports System

Module Exo4

    Sub Main()
        ' Adding some colors
        Console.BackgroundColor = ConsoleColor.Cyan
        Console.ForegroundColor = ConsoleColor.Black

        ' Clearing the console so the whole backgound is colored
        Console.Clear()


        Dim names As New ArrayList()
        ' Initial list of names
        'names.AddRange(New String() {"Louis", "Marie", "Victor", "Magalie", "Jean-Philippe"})
        names.Add("Louis")
        names.Add("Marie")
        names.Add("Victor")
        names.Add("Magalie")
        names.Add("Jean-Philippe")

        ' Show the header
        Console.WriteLine("*************************************************************")
        Console.WriteLine("************************* EXO4 ******************************")
        Console.WriteLine("*************************************************************")
        Console.WriteLine(vbNewLine)
        System.Threading.Thread.Sleep(500) ' Pause for 200 ms

        ' Show the loading text with delays
        Console.WriteLine("----------> Loading the program")
        System.Threading.Thread.Sleep(500) ' Pause for 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        ' Show the loading text with delays
        Console.WriteLine("----------> Booting the system")
        System.Threading.Thread.Sleep(500) ' Pause for 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine("----------> Starting the engine")
        System.Threading.Thread.Sleep(500) ' Pause for 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("Please wait...")
        System.Threading.Thread.Sleep(1000) ' Final pause for 800 ms

        ' Now clear the console after the loading sequence
        Console.Clear()




        Do
            ' Keep the program running until the condition is true
            Dim appRunning As Boolean = True
            While appRunning
                ' Waiting before displaying the menu
                System.Threading.Thread.Sleep(800)
                Console.WriteLine("*************************************************************")
                Console.WriteLine("************************* EXO4 ******************************")
                Console.WriteLine("*************************************************************")
                Console.WriteLine()
                Console.WriteLine("Choose an option:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Delete")
                Console.WriteLine("3. Count")
                Console.WriteLine("4. Count the longest name in the list")
                Console.WriteLine("5. Display List")
                Console.WriteLine("0. Exit")
                Console.WriteLine()

                ' I'm using string (simpler for the validation)
                Dim userChoice As String = Console.ReadLine()
                ' Clearing the console when the user makes a choice
                Console.Clear()
                Select Case userChoice
                    Case "1"
                        ' Loop until the user provides a valid name
                        Do
                            Console.WriteLine()
                            Console.WriteLine("******* ADDING A NAME ************")
                            Console.WriteLine("Please enter a name:")
                            Console.WriteLine()
                            ' Validation for the name
                            Dim newName As String = Console.ReadLine()
                            If (newName = "") Then
                                Console.WriteLine()
                                Console.WriteLine("The name cannot be empty")
                                Console.WriteLine()
                            Else
                                ' Adding the name
                                names.Add(newName)
                                Console.WriteLine(newName & " was added to the list.")
                                Console.WriteLine(vbNewLine)
                                Exit Do
                            End If
                        Loop

                    Case "2"
                        Console.WriteLine()
                        Console.WriteLine("******* DELETE A NAME ************")
                        Console.WriteLine("Enter a name to delete:")
                        Dim nameToRemove As String = Console.ReadLine()
                        ' Removing the name
                        ' Build-in function "Contains" = realy useful!!!
                        If names.Contains(nameToRemove) Then
                            names.Remove(nameToRemove)
                            Console.WriteLine(nameToRemove & " was deleted from the list.")
                            Console.WriteLine(vbNewLine)
                        Else
                            Console.WriteLine("Name not found.")
                            Console.WriteLine()
                        End If
                        Console.WriteLine(vbNewLine)

                    Case "3"
                        Console.WriteLine()
                        Console.WriteLine("******* COUNTING THE LONGEST NAME IN THE  LIST************")
                        Console.WriteLine($"There are {names.Count} names in the list.")
                        Console.WriteLine()

                    Case "4"
                        Console.WriteLine()
                        Dim longestName As String = names.Cast(Of String)().OrderByDescending(Function(n) n.Length).FirstOrDefault()
                        If longestName IsNot Nothing Then
                            Console.WriteLine($"The longest name is {longestName} with {longestName.Length} characters.")
                        Else
                            Console.WriteLine("The list is empty.")
                        End If
                        Console.WriteLine(vbNewLine)


                    Case "5"
                        Console.WriteLine()
                        Console.WriteLine("******* DISPLAY THE NAMES ************")
                        Console.WriteLine("Names in the list:")
                        ' Delaring count to show the number before each name
                        Dim count As Integer = 1
                        For Each name As String In names
                            Console.WriteLine(count & ". " & name)
                            count += 1
                        Next
                        Console.WriteLine(vbNewLine)
                        ' Waiting 1 second
                        System.Threading.Thread.Sleep(1000)

                    Case "0"
                        appRunning = False
                        Console.WriteLine()
                        Console.WriteLine("                               *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
                        Console.WriteLine("                                Thanks for using EXO4, a Major Software")
                        Console.WriteLine("                               *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
                        Console.WriteLine(vbNewLine)
                        ' Wait 2 seconds before restarting
                        System.Threading.Thread.Sleep(2000)
                        Console.Clear()
                    Case Else
                        Console.WriteLine("Invalid option, please try again.")
                End Select
            End While
        Loop
    End Sub

End Module

