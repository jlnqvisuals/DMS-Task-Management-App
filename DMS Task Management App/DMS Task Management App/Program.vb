

Imports System.Collections.Generic
Imports System.Diagnostics.Metrics
Imports System.Threading

Module Module1

    Dim tasks As New SortedList(Of Integer, String)





    Sub Main()



        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                 (c) COPYRIGHT 2024 ")
        Console.WriteLine("                            _________       ____    ____        _________                  ")
        Console.WriteLine("                           |||||||||||     |||||\  //||||      |||||||||||                 ")
        Console.WriteLine("                            ```||||```     ||||\\\///||||      ||||______                  ")
        Console.WriteLine("                               ||||        |||| \\// ||||      |||||||||||                 ")
        Console.WriteLine("                               ||||    __  ||||  ``  ||||  __   ______||||  __             ")
        Console.WriteLine("                               ||||   |||| ||||      |||| |||| ||||||||||| ||||            ")
        Console.WriteLine("                                ``     ``   ``        ``   ``   `````````   ``             ")
        Console.WriteLine("                     ___   _____  _____  _     _   ___    ___   _____  _   ___   ____      ")
        Console.WriteLine("                    / _ \ |  _  \|  _  \| |   |=| / _,\  / _ \ |     ||=| / _ \ |    \     ")
        Console.WriteLine("                   | | | ||  `  /|  `  /| |   | || |  _ | | | | `| |` | || | | || | | |    ")
        Console.WriteLine("                   |  `  || |``` | |``` | |__ | || \_/ ||  `  |  | |  | || \_/ || | | |    ")
        Console.WriteLine("                   | |`| || |    | |    |    || | \   / | |`| |  | |  | | \   / | | | |    ")
        Console.WriteLine("                    `   `  `      `      ````` `   ```   `   `    `    `   ```   `   `     ")
        Console.WriteLine("                         __________________________________________________________        ")
        Console.WriteLine("                        |       T A S K   M A N A G E M E N T   S Y S T E M        |       ")
        Console.WriteLine("                         ``````````````````````````````````````````````````````````        ")
        Console.WriteLine("                               A.Y. 2023- 2024 | BSCPE 2C | CPESOFD | LAB 4                ")
        Console.WriteLine("                                     V.2201691 | VB Console App - OOP              ")
        Console.Beep()
        Console.Beep()
        Console.Beep()


        Thread.Sleep(1100)
        Console.Clear()







        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                                   ______________________                            ")
        Console.WriteLine("                                  //````````````````````\\                           ")
        Console.WriteLine("                          ..  ___||______________________||___  ..     ___           ")
        Console.WriteLine("                          || //\\||//\\  //\\  //\\  //\\||//\\ ||  __//|\\_         ")
        Console.WriteLine("                          ||//__\\//__\\//__\\//__\\//__\\//__\\||  `O----O~'        ")
        Console.WriteLine("                         =======================================================      ")
        Console.WriteLine()
        Console.WriteLine("                                T A S K  M A N A G E M E N T  S Y S T E M                 ")
        Console.WriteLine("                                 DEVELOPED BY DATA MANAGEMENT SOLUTIONS                  ")

        Console.Beep()
        Console.Beep()
        Thread.Sleep(2400)
        Console.Clear()


        While True
            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("                 (c) COPYRIGHT 2024 ")
            Console.WriteLine("                            _________       ____    ____        _________                              ")
            Console.WriteLine("                           |||||||||||     |||||\  //||||      |||||||||||                             ")
            Console.WriteLine("                            ```||||```     ||||\\\///||||      ||||______                              ")
            Console.WriteLine("                               ||||        |||| \\// ||||      |||||||||||                             ")
            Console.WriteLine("                               ||||    __  ||||  ``  ||||  __   ______||||  __                         ")
            Console.WriteLine("                               ||||   |||| ||||      |||| |||| ||||||||||| ||||                        ")
            Console.WriteLine("                                ``     ``   ``        ``   ``   `````````   ``                         ")
            Console.WriteLine("                         __________________________________________________________                    ")
            Console.WriteLine("                        |       T A S K   M A N A G E M E N T   S Y S T E M        |                   ")
            Console.WriteLine("                         ``````````````````````````````````````````````````````````                    ")
            Console.WriteLine("                 _____________________________________________________________________________         ")
            Console.WriteLine()
            Console.WriteLine("                          __________________________   __________________________       ")
            Console.WriteLine("                         | 1 ! ADD TASK             | | 3 ! VIEW TASK            |      ")
            Console.WriteLine("                          ==========================   ==========================       ")
            Console.WriteLine("                         | 2 ! REMOVE TASK          | | 0 ! EXIT APP             |      ")
            Console.WriteLine("                          ``````````````````````````   ``````````````````````````       ")
            Console.WriteLine()
            Console.Write("               >> ENTER YOUR CHOICE: ")

            Dim choice As Integer
            Integer.TryParse(Console.ReadLine(), choice)

            Select Case choice
                Case 1
                    AddTask()
                Case 2
                    RemoveTask()
                Case 3
                    ViewTasks()
                Case 0
                    'Environment.Exit(0)
                    AppExit()
                Case 69
                    DevInf()
                Case Else

                    Console.WriteLine("               >> Invalid choice. Please try again!")
                    Console.Beep()
                    Thread.Sleep(2000)
                    Console.Clear()
            End Select
        End While
    End Sub






    Sub AddTask()
        Console.WriteLine()
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                 (c) COPYRIGHT 2024 ")
        Console.WriteLine("                            _________       ____    ____        _________                              ")
        Console.WriteLine("                           |||||||||||     |||||\  //||||      |||||||||||                             ")
        Console.WriteLine("                            ```||||```     ||||\\\///||||      ||||______                              ")
        Console.WriteLine("                               ||||        |||| \\// ||||      |||||||||||                             ")
        Console.WriteLine("                               ||||    __  ||||  ``  ||||  __   ______||||  __                         ")
        Console.WriteLine("                               ||||   |||| ||||      |||| |||| ||||||||||| ||||                        ")
        Console.WriteLine("                                ``     ``   ``        ``   ``   `````````   ``                         ")
        Console.WriteLine("                         __________________________________________________________                    ")
        Console.WriteLine("                        |       T A S K   M A N A G E M E N T   S Y S T E M        |                   ")
        Console.WriteLine("                         ``````````````````````````````````````````````````````````                    ")
        Console.WriteLine("                 _____________________________________________________________________________         ")
        Console.WriteLine()
        Console.Write("                       >> Enter task description: ")
        Console.Beep()
        Console.Beep()
        Dim description As String = Console.ReadLine()

        'Console.Clear()
        Console.WriteLine()
        Console.Write("                       >> Enter task priority (1-5, 1 being the highest priority): ")
        Console.Beep()
        Dim priority As Integer
        Integer.TryParse(Console.ReadLine(), priority)

        If priority >= 1 AndAlso priority <= 5 Then
            If Not tasks.ContainsKey(priority) Then
                tasks.Add(priority, description)
                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                                                            __        ")
                Console.WriteLine("                                                   ________/ /        ")
                Console.WriteLine("                                                  | __    / / |       ")
                Console.WriteLine("                                                  | \ \  / /  |       ")
                Console.WriteLine("                                                  |  \ \/ /   |       ")
                Console.WriteLine("                                                  |   \  /    |       ")
                Console.WriteLine("                                                  |    ``     |       ")
                Console.WriteLine("                                                   ````````````       ")
                Console.WriteLine("                       ...................................................................                 ")
                Console.WriteLine("                      :                       TASK ADDED SUCCESSFULLY!                    :                ")
                Console.WriteLine("                       ```````````````````````````````````````````````````````````````````                 ")
                Thread.Sleep(2000)
                Console.Beep()
            Else

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                       ...................................................................                 ")
                Console.WriteLine($"                      :             TASK WITH PRIORITY {priority} IS ALREADY OCCUPIED              :                ")
                Console.WriteLine("                       ```````````````````````````````````````````````````````````````````                 ")
                Thread.Sleep(2000)
                Console.Beep()
                Console.Beep()
                Console.Beep()
            End If
        Else
            Console.Clear()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("                          ...................................................................                 ")
            Console.WriteLine("                         :         INVALID INPUT, PRIORITY MUST BE BETWEEN 1 AND 5!          :                ")
            Console.WriteLine("                          ```````````````````````````````````````````````````````````````````                 ")
            Console.Beep()
            Console.Beep()
            Console.Beep()
            Console.Beep()
            Thread.Sleep(2000)
        End If

        Console.WriteLine()
    End Sub







    Sub RemoveTask()
        Console.WriteLine()
        If tasks.Count > 0 Then
            Console.Clear()
            Console.Beep()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("       ___________________________")
            Console.WriteLine("      /  * TASKS AVAILABLE      //")
            Console.WriteLine("      ```````````````````````````")
            For Each task In tasks
                Console.Write("       ")
                Console.WriteLine($"{task.Key}: {task.Value}")
            Next
            Console.WriteLine()

            'Console.Clear()
            Console.Beep()
            Console.Beep()
            Console.Write("      >> Enter the priority of the task to remove: ")
            Dim priorityToRemove As Integer
            Integer.TryParse(Console.ReadLine(), priorityToRemove)

            If tasks.ContainsKey(priorityToRemove) Then
                tasks.Remove(priorityToRemove)
                Console.Beep()
                Console.Beep()
                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                       ...................................................................                 ")
                Console.WriteLine("                      :                     TASK REMOVED SUCCESSFULLY!                    :                ")
                Console.WriteLine("                       ```````````````````````````````````````````````````````````````````                 ")
                Thread.Sleep(2000)

            Else
                Console.Beep()
                Console.Beep()
                Console.Beep()

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                                                _________________⠀       ")
                Console.WriteLine("                                               /  _____________  \⠀      ")
                Console.WriteLine("                                               | |             | |⠀      ")
                Console.WriteLine("                                               | |   x     x   | |⠀      ")
                Console.WriteLine("                                               | |             | |⠀      ")
                Console.WriteLine("                                               | |    =====    | |⠀      ")
                Console.WriteLine("                                               | |_____________| | ⠀     ")
                Console.WriteLine("                                               \ ________________/⠀      ")
                Console.WriteLine("                                                |           ooo |⠀       ")
                Console.WriteLine("                                                 ````````````````⠀       ")
                Console.WriteLine()
                Console.WriteLine("                       ...................................................................                 ")
                Console.WriteLine("                      :               TASK WITH SPECIFIED PRIORITY NOT FOUND!             :                ")
                Console.WriteLine("                       ```````````````````````````````````````````````````````````````````                 ")
                Thread.Sleep(2000)







            End If
        Else

            Console.Clear()
            Console.Beep()
            Console.Beep()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("                       ...................................................................                 ")
            Console.WriteLine("                      :                         NO TASK TO REMOVE                         :                ")
            Console.WriteLine("                       ```````````````````````````````````````````````````````````````````                 ")
            Thread.Sleep(2000)
        End If

        Console.WriteLine()
    End Sub






    Sub ViewTasks()
        Console.Clear()
        Console.WriteLine()
        If tasks.Count > 0 Then
            Console.Beep()

            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("       ___________________________")
            Console.WriteLine("      /  * TASKS AVAILABLE      //")
            Console.WriteLine("      ```````````````````````````")

            For Each task In tasks
                Console.Write("    ")
                Console.WriteLine($"   >> {task.Key}: {task.Value}")
                Thread.Sleep(1500)
                'Console.Clear()
            Next
        Else
            Console.Clear()
            Console.Beep()
            Console.Beep()
            Console.Beep()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("                       ...................................................................                 ")
            Console.WriteLine("                      :                           NO TASK AVAILABLE                       :                ")
            Console.WriteLine("                       ```````````````````````````````````````````````````````````````````                 ")
            Thread.Sleep(2000)

        End If

        Console.WriteLine()
    End Sub







    Sub AppExit()

        Console.Clear()
        Console.Beep()
        Console.Beep()
        Console.Beep()
        Console.Beep()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                 (c) COPYRIGHT 2024 ")
        Console.WriteLine("                            _________       ____    ____        _________                  ")
        Console.WriteLine("                           |||||||||||     |||||\  //||||      |||||||||||                 ")
        Console.WriteLine("                            ```||||```     ||||\\\///||||      ||||______                  ")
        Console.WriteLine("                               ||||        |||| \\// ||||      |||||||||||                 ")
        Console.WriteLine("                               ||||    __  ||||  ``  ||||  __   ______||||  __             ")
        Console.WriteLine("                               ||||   |||| ||||      |||| |||| ||||||||||| ||||            ")
        Console.WriteLine("                                ``     ``   ``        ``   ``   `````````   ``             ")
        Console.WriteLine("                     ___   _____  _____  _     _   ___    ___   _____  _   ___   ____      ")
        Console.WriteLine("                    / _ \ |  _  \|  _  \| |   |=| / _,\  / _ \ |     ||=| / _ \ |    \     ")
        Console.WriteLine("                   | | | ||  `  /|  `  /| |   | || |  _ | | | | `| |` | || | | || | | |    ")
        Console.WriteLine("                   |  `  || |``` | |``` | |__ | || \_/ ||  `  |  | |  | || \_/ || | | |    ")
        Console.WriteLine("                   | |`| || |    | |    |    || | \   / | |`| |  | |  | | \   / | | | |    ")
        Console.WriteLine("                    `   `  `      `      ````` `   ```   `   `    `    `   ```   `   `     ")
        Console.WriteLine("                    ...................................................................                 ")
        Console.WriteLine("                   :  T H A N K   Y O U   F O R   U S I N G   O U R   P R O G R A M !  :                ")
        Console.WriteLine("                    ```````````````````````````````````````````````````````````````````                 ")
        Console.WriteLine("                               A.Y. 2023- 2024 | BSCPE 2C | CPESOFD | LAB 4                ")
        Console.WriteLine("                                     V.2201691 | VB Console App - OOP              ")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Thread.Sleep(2000)
        Environment.Exit(0)


        Console.Beep()
        Console.Beep()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                                   ______________________                            ")
        Console.WriteLine("                                  //````````````````````\\                           ")
        Console.WriteLine("                          ..  ___||______________________||___  ..     ___           ")
        Console.WriteLine("                          || //\\||//\\  //\\  //\\  //\\||//\\ ||  __//|\\_         ")
        Console.WriteLine("                          ||//__\\//__\\//__\\//__\\//__\\//__\\||  `O----O~'        ")
        Console.WriteLine("                         =======================================================      ")
        Console.WriteLine()
        Console.WriteLine("                                T A S K  M A N A G E M E N T  S Y S T E M                 ")
        Console.WriteLine("                                 DEVELOPED BY DATA MANAGEMENT SOLUTIONS                  ")


        Thread.Sleep(2400)
        Console.Clear()





    End Sub


    Sub DevInf()
        Console.Beep()
        Console.Beep()
        Console.WriteLine("               >> This Program Is Developed By: Quilino, John Lloyd N. ")
        Console.WriteLine("                                                Data Management Solutions! ")
        Console.WriteLine("                                                Colegio de Montalban ")
        Console.WriteLine("                                                BSCPE 2C | CPESOFD ")
        Thread.Sleep(2500)
        Console.Clear()

    End Sub


End Module







