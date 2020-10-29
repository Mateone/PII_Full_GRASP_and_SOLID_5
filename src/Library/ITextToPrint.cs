
namespace Full_GRASP_And_SOLID
{
    /*
        Se desacoplo la clase de Recipe de la interfaz IPrinter y todas las clases que la implementan, 
        de esta manera las clases dependen de esta interfaz (una abstraccion)
        Recipe implementa esta interfaz y los printer reciben por parametro un objeto del tipo ITextToPrint
        del cual utiliza la operacion GetTextToPrint para obtener el texto a imprimir.
        Con estos cambios logramos reducir la rigidez, la fragilidad y la baja reutilización de nuestro programa.
    */
    public interface ITextToPrint
    {
        string GetTextToPrint();
    }
}