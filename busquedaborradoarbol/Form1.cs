using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busquedaborradoarbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        alumno raiz = null;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            alumno actual;
            if(raiz==null)
            {
                raiz= new alumno();
                raiz.nombre=txtnombre.Text;
                raiz.matricula = (int)nudmatricula.Value;
                raiz.calif=nudcalif.Value;
                return;
            }
            actual = raiz;
            do
            {
                if (actual.matricula < nudmatricula.Value)
                {
                    if (actual.der == null)
                    {
                        actual.der = new alumno();
                        actual = actual.der;
                        actual.nombre = txtnombre.Text;
                        actual.matricula = (int)nudmatricula.Value;
                        actual.calif = nudcalif.Value;
                        return;

                    }
                    actual = actual.der;
                }
                else if (actual.matricula > nudmatricula.Value)
                {
                    if (actual.izq == null)
                    {
                        actual.izq = new alumno();
                        actual = actual.izq;
                        actual.nombre = txtnombre.Text;
                        actual.matricula = (int)nudmatricula.Value;
                        actual.calif = nudcalif.Value;
                        return;

                    }
                    actual = actual.izq;
                }
                else
                {
                    MessageBox.Show("esta matricula ya existe");
                    return;
                }
            }while(true);
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            alumno actual = raiz;
            while(actual != null)
            {
                if(actual.matricula==nudmatricula.Value)
                {
                    txtnombre.Text = actual.nombre;
                    nudcalif.Value = actual.calif;
                    return;
                }
                if (actual.matricula < nudmatricula.Value)
                    actual = actual.der;
                else
                    actual= actual.izq;
            }
            MessageBox.Show("elemento no encontrado");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (raiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int matricula = (int)nudmatricula.Value;

            // Variables to keep track of parent and current node during traversal
            alumno parent = null;
            alumno current = raiz;

            // Find the node to delete
            while (current != null && current.matricula != matricula)
            {
                parent = current;

                if (matricula < current.matricula)
                    current = current.izq;
                else
                    current = current.der;
            }

            if (current == null)
            {
                MessageBox.Show("No se encontró el alumno con esa matricula.");
                return;
            }

            // Case 1: Node to delete has no child nodes
            if (current.izq == null && current.der == null)
            {
                if (parent == null)
                {
                    // Node to delete is the root
                    raiz = null;
                }
                else if (parent.izq == current)
                {
                    parent.izq = null;
                }
                else
                {
                    parent.der = null;
                }
            }
            // Case 2: Node to delete has one child node
            else if (current.izq == null || current.der == null)
            {
                alumno child = current.izq ?? current.der; // Get the non-null child node

                if (parent == null)
                {
                    // Node to delete is the root
                    raiz = child;
                }
                else if (parent.izq == current)
                {
                    parent.izq = child;
                }
                else
                {
                    parent.der = child;
                }
            }
            // Case 3: Node to delete has two child nodes
            else
            {
                // Find the inorder successor (smallest value larger than current node)
                alumno successorParent = current;
                alumno successor = current.der;

                while (successor.izq != null)
                {
                    successorParent = successor;
                    successor = successor.izq;
                }

                // If the successor is not the right child of the node to delete,
                // update the references to replace the successor with its right child
                if (successorParent != current)
                {
                    successorParent.izq = successor.der;
                    successor.der = current.der;
                }

                successor.izq = current.izq; // Replace the node to delete with the successor

                if (parent == null)
                {
                    // Node to delete is the root
                    raiz = successor;
                }
                else if (parent.izq == current)
                {
                    parent.izq = successor;
                }
                else
                {
                    parent.der = successor;
                }
            }

            MessageBox.Show("Elemento borrado correctamente.");
        }
    }
}
