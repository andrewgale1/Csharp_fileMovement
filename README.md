## Csharp_fileMovement

This is an exercise done for C#/.NET course. The assignment was to create a console application that would check a folder for any files created or modified in the last 24 hours and then move these files to another folder.
After initially getting the program to work with all the code in the main function, I moved all the action into a file_mover function outside of the main function that is then called in main. 
I also discovered that the GetLastWriteTime method was returning the folder's last modification time instead of the files inside, and found that by adding the file to source in the method call it returned the desired file modification times. 
The program seems to be working correctly now.
