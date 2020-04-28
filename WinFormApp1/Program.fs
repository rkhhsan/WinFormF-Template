open System.Drawing
open System.Windows.Forms
open System
open System.IO

// --------------------------------------------------------------------------
// Modelo de Windows Form com um botão
// --------------------------------------------------------------------------
// Create main form window
let mainForm = new Form(Width = 620, Height = 450, Text = "First F# Windows Form")
let mutable button = 
    new Button(Location=new Point(40,20), Width = 160, Height = 40, Text = "Click me to close!")

button.Click.Add(fun _ -> Application.Exit() |> ignore)
mainForm.Controls.Add(button)
// Entry-point for the graphical version   
[<STAThread>]
do // Specify event handlers - a function called when button is clicked
   Application.EnableVisualStyles()
   Application.Run(mainForm)
