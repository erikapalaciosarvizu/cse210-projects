// member variables to store date of entry
// text of entry, and prompt used for entry
using System;

public class Entry
{
    string promptJournal { get; set; } //que a cada una de las variables puedo obtener y setear su valor
    string userResponse { get; set; }
    string dateText { get; set; }

    //Constuctor:
    public Entry(string prompt, string response)
    {
        promptJournal = prompt; //el promptJournal se guarda en el prompt
        userResponse = response; //el userResponse se guarda en el response
        dateText = DateTime.Now.ToShortDateString(); //DateTime es un objeto que puede traer algunos otros valores. En este caso una varoable llamada now= fecha actual en la que s ejecuta mi linea de codigo. ToShortDateString e sun metodo que se le aplica al now y convierte el valor de now a un texto de fecha corta
    }

    public override string ToString()
    {
        return $"{dateText} - {promptJournal} - {userResponse}";
    }
}