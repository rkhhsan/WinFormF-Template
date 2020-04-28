open System.Drawing
open System.Windows.Forms
open System
open System.IO

// --------------------------------------------------------------------------
// Modelo de Windows Form com Text Box
// --------------------------------------------------------------------------
// Create main form window
let form = new Form(Visible = true, Text = "Displaying data in F#", TopMost = true, Size = Drawing.Size(600, 600))
// Create the text box
let textBox = 
    new RichTextBox(Dock = DockStyle.Fill, Text = "This is a text box that we can feed data into", 
                    Font = new Font("LucidaConsole", 10.0f, FontStyle.Regular), ForeColor = Color.DarkBlue)

form.Controls.Add textBox

// Create the button
let button = new Button(Dock = DockStyle.Bottom, Width = 160, Height = 40, Text = "Click to clear the text box")

//button.Click.Add(fun _ -> Application.Exit() |> ignore)

form.Controls.Add button
  

let show a x =    
    textBox.Text <-  textBox.Text+"\n\n"+a+sprintf "%30A" x

show "tripla\n" (1,2)
show "tripla\n" (1,2,4)
show "sequencia\n" [ 0 .. 100 ]
show "sequencia\n" [ 0.0 .. 2.0 .. 100.0 ]
show ""(1,2)

/// Limpa a tela
let limpaTela(e) =
    textBox.Clear()  


// Entry-point for the graphical version   
[<STAThread>]
do // Specify event handlers - a function called when button is clicked
   button.Click.Add(limpaTela)
   Application.EnableVisualStyles()
   Application.Run(form)
