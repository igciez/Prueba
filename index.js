function Persona (nombre, edad){
    this.nombre=nombre; //--> el this se refiere a windows a no ser que se use una arrow o que se pase a una variable la funcion.
    this.edad=edad;          // donde el this hara referencia a la variable que se paso, pero no al nombre de la funcion.   
}

//el "new" asocia el objeto al prototype de la nueva variable 
//y el constructor que genera es una referencia a si mismo.
// regla: instancia.__proto__ === Class.prototype
// herencia de cadena a prototipo.
//El prototipo es lo que van a compartir las distintas varibles que comparten el constructor (new)

let juan= new Persona("nombre",28);

/***
 * Atributos de configuracion de propiedades de objetos:
 *       Tipos: value - writable -configurable - enumerable
 *   se usa en object.defineProperty(this, "nombre" =>{
 *              value: ,
 *              writable: false (viene por defecto),
 * })
 */

 /***
  * Herencia: 
  *     ver reglas 
  * --> va de principio(primera) a fin(ultima) -> en igualdad, se invierte orden -> ultima=primera 
  * --> ya que la primera es mas grande que la ultima. Parece ser mas un direccionamiento que una igualdad.
  * Es una asociacion por lo igual. 
  */

  /***
   * Composicion: simula ser un super(); de java o c# --> se usa el call o aply. (MODELO CLASICO)
   */

   /**
    * MODEL ECMA script 6
    * class Persona{  --> es una funcion, justificar con console.dir(persona) donde se encuentra el prototype
    * }
    * 
    */
  
   //----------------NODE----------------------------//
    /**
    * Funciones auto invocadas --> IFEE
    *  Son dos parentesis juntos ()(); --> son modulos
    *  son funciones seguras porque no salen al "window
    */
   /**
    * NODE: es un entorno de desarrollo que puede correr js, c, c++ etc.
    *       es java script del lado del sistema operativo, ej se puede abrir puertos. 
    *
    * Contiene modulos nativos: que son bibliotecas propias
    * 
    * Comandos : NPM: node packge manager
    * 
    *   -g -> se instala el paquete a nivel global (sistema operativo)
    *   -s -> se instala en carpeta local para produccion
    *   -d -> es para dev para desarrollo
    */

    /***
     * REACT
     * Tiene dos librerias: React
     *                      React DOM
     * Internamente hay un render, que es una funcion autoinvocada. 
     * Reglas:
     *      React en scope: import -> de ECMA6
     *                      const React= require ("react") -> segunda manera de importar
     *      Componente: son funciones tipo flecha, tipo class. 
     *                  todos deben retornar algo -> JSX - React.component - String -DomNode
     *                  todos los componentes van en mayusculas ->porque sino la compila como etiqueta
     *                  se escriben en JSX: funcition App(); App() === <App>
     */