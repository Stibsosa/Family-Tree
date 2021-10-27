using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);*/

            Persona uno = new Persona("Rojo",10);
            Persona dos = new Persona("Amarillo",11);
            Persona tres = new Persona("Azul",12);
            Persona cuatro = new Persona("Verde",13);
            Persona cinco = new Persona("Violeta",14);
            Persona seis = new Persona("Rosa",15);
            Persona siete = new Persona("Marrón",16);
            Persona ocho = new Persona("Negro",17);

            Node nuno = new Node(uno);
            Node ndos = new Node(dos);
            Node ntres = new Node(tres);
            Node ncuatro = new Node(cuatro);
            Node ncinco = new Node(cinco);
            Node nseis = new Node(seis);
            Node nsiete = new Node(siete);
            Node nocho = new Node(ocho);

            
            nuno.AddChildren(ndos);
            nuno.AddChildren(ntres);
            
            

            // visitar el árbol aquí
        }
    }
}
