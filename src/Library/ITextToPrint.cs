
namespace Full_GRASP_And_SOLID
{
    /*
        Se desacoplo la clase Recipe de la interfaz IPrinter y todas las clases que implementen a esta última, 
        pues de esta manera las clases dependerán de esta interfaz (una abstraccion).
        Recipe implementa esta interfaz y los printer reciben por parametro un objeto del tipo ITextToPrint
        del cual utiliza la operacion GetTextToPrint para obtener el texto a imprimir.
        Es de esta manera (aplicando el principio de inversión de dependencias), que logramos que la clases que
        implementen esta interfaz, no dependan estrictamente de la clase Recipe, cumpliendo además así con el
        OCP, pues con esta nueva implementación, en caso de que se quiera imprimir un nuevo texto que no sea necesariamente una receta, 
        será posible sin tener que modificar el código ya existente.
        Con estos cambios logramos además, reducir la rigidez, la fragilidad y la inamovilidad de nuestro programa, y por otra parte
        aumentar la reutilización del mismo.
    */
    public interface ITextToPrint
    {
        string GetTextToPrint();
    }
}