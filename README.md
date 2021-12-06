# ToDoApp

In case of issues running this project, do the following (Linux Ubuntu only):

1. Navigate to the project folder (ToDoApp) and turn the Program.cs file into an executable file (right-click, select Properties, go to Permissions, and check the "Allow executing file as program" box). 
2. Go to terminal.
2. Type `sudo apt install mono-complete` then hit ENTER.
4. Once installation is complete, navigate to the project folder (ToDoApp) via the terminal.
5. Type `mcs -out:todo.exe Program.cs` and hit ENTER.
6. Type `mono todo.exe` and hit ENTER.
