using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Compilador
{
    public partial class FrmCompilador : Form
    {
        string[] palabras;

        List<Tuple<string,string>> PalabrasReservadas = new List<Tuple<string, string>>();

        //Palabras
        //{ { "READLINE","PRINTIN","STRING","INT","BOOL","DOUBLE","CONST","FOR","WHILE","DO","IF","ELSE","INICIO", "FINAL", "(", ")", "=" }
        //                                ,{"PR01","PR02","PR03","PR04","PR05","PR06","PR07","PR08","PR09","PR10","PR11","PR12","PR13","PR14","OPER1","PR16","PR17"} }
        public FrmCompilador()
        {
            InitializeComponent();
        }

        //Declaracion de palabras reservadas
        private void Form1_Load(object sender, EventArgs e)
        {
            //Palabras reservadas
            PalabrasReservadas.Add(new Tuple<string, string>("readline","PR01"));
            PalabrasReservadas.Add(new Tuple<string, string>("ReadLine", "PR01"));
            PalabrasReservadas.Add(new Tuple<string, string>("println", "PR02"));
            PalabrasReservadas.Add(new Tuple<string, string>("Println", "PR02"));

            PalabrasReservadas.Add(new Tuple<string, string>("for", "PR08"));
            PalabrasReservadas.Add(new Tuple<string, string>("while", "PR09"));
            PalabrasReservadas.Add(new Tuple<string, string>("do", "PR10"));
            PalabrasReservadas.Add(new Tuple<string, string>("if", "PR11"));
            PalabrasReservadas.Add(new Tuple<string, string>("else", "PR12"));

            PalabrasReservadas.Add(new Tuple<string, string>("inicio", "PR13"));
            PalabrasReservadas.Add(new Tuple<string, string>("final", "PR14"));
            PalabrasReservadas.Add(new Tuple<string, string>("Inicio", "PR13"));
            PalabrasReservadas.Add(new Tuple<string, string>("Final", "PR14"));

            //Tipos de datos
            PalabrasReservadas.Add(new Tuple<string, string>("string", "PR03"));
            PalabrasReservadas.Add(new Tuple<string, string>("int", "PR04"));
            PalabrasReservadas.Add(new Tuple<string, string>("bool", "PR05"));
            PalabrasReservadas.Add(new Tuple<string, string>("double", "PR06"));
            PalabrasReservadas.Add(new Tuple<string, string>("const", "PR07"));
            
            PalabrasReservadas.Add(new Tuple<string, string>("String", "PR03"));
            PalabrasReservadas.Add(new Tuple<string, string>("Int", "PR04"));
            PalabrasReservadas.Add(new Tuple<string, string>("Bool", "PR05"));
            PalabrasReservadas.Add(new Tuple<string, string>("Double", "PR06"));
            PalabrasReservadas.Add(new Tuple<string, string>("Const", "PR07"));

            //Identificadores
            PalabrasReservadas.Add(new Tuple<string, string>("iden", "IDEN"));

            //Operadores
            PalabrasReservadas.Add(new Tuple<string, string>("+", "OPER01"));
            PalabrasReservadas.Add(new Tuple<string, string>("-", "OPER02"));
            PalabrasReservadas.Add(new Tuple<string, string>("/", "OPER03"));
            PalabrasReservadas.Add(new Tuple<string, string>("*", "OPER04"));
            PalabrasReservadas.Add(new Tuple<string, string>("^", "OPER05"));

            //Operadores Relacionales
            PalabrasReservadas.Add(new Tuple<string, string>(">", "COMP01"));
            PalabrasReservadas.Add(new Tuple<string, string>("<", "COMP02"));
            PalabrasReservadas.Add(new Tuple<string, string>(">=", "COMP03"));
            PalabrasReservadas.Add(new Tuple<string, string>("<=", "COMP04"));
            PalabrasReservadas.Add(new Tuple<string, string>("<>", "COMP05"));
            PalabrasReservadas.Add(new Tuple<string, string>("==", "COMP06"));

            //Operadores Logicos
            PalabrasReservadas.Add(new Tuple<string, string>("&&", "LOG01"));
            PalabrasReservadas.Add(new Tuple<string, string>("||", "LOG02"));
            PalabrasReservadas.Add(new Tuple<string, string>("!", "LOG03"));

            //Caracteres especiales
            PalabrasReservadas.Add(new Tuple<string, string>("@", "CE01"));
            PalabrasReservadas.Add(new Tuple<string, string>("$", "CE02"));
            PalabrasReservadas.Add(new Tuple<string, string>("#", "CE03"));
            PalabrasReservadas.Add(new Tuple<string, string>("(", "CE04"));
            PalabrasReservadas.Add(new Tuple<string, string>(")", "CE05"));
            PalabrasReservadas.Add(new Tuple<string, string>("{", "CE06"));
            PalabrasReservadas.Add(new Tuple<string, string>("}", "CE07"));

            //Asignacion
            PalabrasReservadas.Add(new Tuple<string, string>("=", "ASIGN01"));

            //Cometario y Letrero
            PalabrasReservadas.Add(new Tuple<string, string>("Comentario", "COM"));
            PalabrasReservadas.Add(new Tuple<string, string>("Letrero", "LET"));
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Agregar en simbolos o revision de palabras reservadas
        public string Encontrar(string PR)
        {
            foreach (var item in PalabrasReservadas)
            {
                if (PR == item.Item1)
                {
                    foreach (DataGridViewRow row in dtgSimbolos.Rows)
                    {
                        string codigo = Convert.ToString(row.Cells["nombreid"].Value);
                        if (item.Item1 == codigo)
                        {
                            return item.Item2;
                        }
                    }
                    dtgSimbolos.Rows.Add(id, item.Item1, item.Item2);
                    return item.Item2;

                }
            }
            return "null";
        }
        //Funcion que encuentra variables
        public string CheckVariable(string var)
        {
            foreach (DataGridViewRow row in dtgVariables.Rows)
            {
                string codigo = Convert.ToString(row.Cells["variables"].Value);
                if (var == codigo)
                {
                    return Convert.ToString(row.Cells["idvar"].Value);
                }
            }
            return "null";
        }
        //  ____   ____ _______ ____  _   _   _____  _____  _____ _   _  _____ _____ _____        _      
        // |  _ \ / __ \  __ __/ __ \| \ | | |  __ \|  __ \|_   _| \ | |/ ____|_   _|  __ \ /\   | |     
        // | |_) | |  | | | | | |  | |  \| | | |__) | |__) | | | |  \| | |      | | | |__) /  \  | |     
        // |   _<| |  | | | | | |  | | . ` | |  ___/|  _  /  | | | . ` | |      | | |  ___/ /\ \ | |     
        // | |_) | |__| | | | | |__| | |\  | | |    | | \ \ _| |_| |\  | |____ _| |_| |  / ____ \| |____ 
        // |____/ \____/  |_|  \____/|_| \_| |_|    |_|  \_\_____|_| \_|\_____|_____|_| /_/    \_\______|
        private void btnAnalisisLexico_Click(object sender, EventArgs e)
        {
            //Validaciones por si esta vacio
            if (txtFuente.Text == "")
            {
                MessageBox.Show("Introduzca codigo para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            id = 0;
            txtTokens.Clear();
            dtgErrores.Rows.Clear();
            dtgSimbolos.Rows.Clear();
            dtgVariables.Rows.Clear();


            //Identificadores
            int fila = 0; //<-------- Contador de filas
            int ide = 0; //<-------- Contador de identificadores
            int palabra = 0; //<-------- Contador de palabras

            char[] charArray1; //<-------- Arreglo de letras de la primera palabra
            string first1; //<-------- Primer caracter de las palabras

            //Ciclo que recorre las lineas
            foreach (var iden in txtFuente.Lines)
            {
                bool isValidLexic = false;
                //Arreglo donde se guardan las palabras de una fila
                string[] filadata = iden.Split();
                //Ciclo que recorre las palabras de la fila del primer ciclo

                charArray1 = iden.ToCharArray();
                first1 = charArray1[0].ToString();
                foreach (var item in filadata)
                {
                    palabra++; //<-------- Contador de palabras
                    //Revisa si la palabra esta bien escrita
                    isValidLexic = PalabrasReservadas.Any(x => x.Item1 == item);

                    //Checa el lexico de las palabras
                    if (!isValidLexic)
                    {
                        if (first1 == "/" || first1 == "\'")
                        {
                            Console.WriteLine(iden);
                            break;
                        }
                        else if (item != ";")
                        {
                            dtgErrores.Rows.Add(fila, "LEXICO", item);
                        }
                    }
                    else if (item.ToLower() == "int" || item.ToLower() == "string" || item.ToLower() == "bool" || item.ToLower() == "double" || item.ToLower() == "const")
                    {
                        if (!CheckSintaxis(item, filadata, palabra))
                        {
                            dtgErrores.Rows.Add(fila, "SINTAXIS", item);
                            break;
                        }
                        //Parte de codigo donde se revisa si se esta instanciando una variable y checa su sintaxis
                        else
                        {
                            ide++;
                            Console.WriteLine(filadata[palabra + 2].GetType());
                            //Revisa la declaracion si esta bien escrita con contenido de variavles Ejemplo -> int a = x + y ;
                            if ((CheckVariable(filadata[palabra + 2]) != "null" || filadata[palabra + 2].GetType() == typeof(int)) && (filadata[palabra + 3] == "+" || filadata[palabra + 3] == "-" || filadata[palabra + 3] == "/" || filadata[palabra + 3] == "*" || filadata[palabra + 3] == "^") && (CheckVariable(filadata[palabra + 4]) != "null" || filadata[palabra + 4].GetType() == typeof(int)))
                            {
                                string exp = filadata[palabra + 2] + " " + filadata[palabra + 3] + " " + filadata[palabra + 4];
                                dtgVariables.Rows.Add("IDEN" + ide, item, filadata.ElementAt(palabra), exp);
                            }
                            else
                            {
                                //Lo mismo de arriba pero con contenido especifico Ejemplo -> int a = 12 ;
                                dtgVariables.Rows.Add("IDEN" + ide, item, filadata.ElementAt(palabra), filadata.ElementAt(palabra + 2));
                            }
                            break;
                        }
                    }
                    
                }
                //Reset de las palabras
                palabra = 0;
            }
            //Contador de los contenidos
            int contenido = 0;




            //Separa todo el texto en palabras
            palabras = txtFuente.Text.Split();
            //Ciclo donde recorre todas las palabras del codigo fuente
            for (int i = 0; i < palabras.Length; i++)
            {
                bool Esta = false; //<-------- Bandera de validacion para los comentarios y letreros
                char[] charArray; //<-------- Arreglo de letras de la primera palabra
                string first; //<-------- Primer caracter de las palabras
                //Try-Catch que toma el primer caracter para hacer comparaciones
                try
                {
                    charArray = palabras[i].ToCharArray();
                    first = charArray[0].ToString();
                }
                catch (Exception ex)
                {
                    continue;
                }
                //  _______  ____  _  ________ _   _  _____
                // |__   __ / __ \| |/ /  ____| \ | |/ ____|
                //    | |  | |  | | ' /| |__  |  \| | (___  
                //    | |  | |  | |  < |  __| | . ` |\___ \ 
                //    | |  | |__| | . \| |____| |\  |____) |
                //    |_|   \____/|_|\_\______|_| \_|_____/
                //Creacion de tokens
                try
                {
                    //Tokens Normales
                    if (PalabrasReservadas.Any(m => m.Item1 == palabras[i]))
                    {
                        txtTokens.AppendText(Encontrar(palabras[i]) + " ");
                    }
                    //Salto de linea
                    else if (palabras[i] == ";")
                    {
                        txtTokens.AppendText(";\n");
                    }
                    //Checkeo de variables en el codigo
                    else if (CheckVariable(palabras[i]) != "null")
                    {
                        txtTokens.AppendText(CheckVariable(palabras[i]) + " ");
                    }
                    //Comentario
                    else if (first == "/")
                    {
                        while (palabras[i] != ";" || Encontrar(palabras[i]) != "null")
                        {
                            i++;
                        }
                        txtTokens.AppendText("COM ;\n");
                        foreach (DataGridViewRow row in dtgSimbolos.Rows)
                        {
                            string codigo = Convert.ToString(row.Cells["token"].Value);
                            if ("COM" == codigo)
                            {
                                Esta = true;
                            }
                        }
                        if (!Esta)
                        {
                            dtgSimbolos.Rows.Add(id, "Comentario", "COM");
                            Esta = false;
                        }
                    }
                    //Letrero
                    else if (first == "\'")
                    {
                        while (palabras[i] != ";" || Encontrar(palabras[i]) != "null")
                        {
                            i++;
                        }
                        txtTokens.AppendText("LET ;\n");
                        foreach (DataGridViewRow row in dtgSimbolos.Rows)
                        {
                            string codigo = Convert.ToString(row.Cells["token"].Value);
                            if ("LET" == codigo)
                            {
                                Esta = true;
                            }
                        }
                        if (!Esta)
                        {
                            dtgSimbolos.Rows.Add(id, "Letrero", "LET");
                            Esta = false;
                        }
                    }
                    //Checkeo de contenidos
                    else if (i != 0 && palabras[i - 1] == "=" && CheckVariable(palabras[i - 2]) != "null")
                    {
                        contenido++;
                        txtTokens.AppendText("CONT "+contenido);
                        //Revision si es decimal
                        if (Regex.IsMatch(palabras[i], @"^\d{0,10}[.]\d{0,10}"))
                        {
                            dtgVariables.Rows.Add("CONT" + contenido, "Decimal", "CONT" + contenido, palabras[i]);
                        }
                        //Revision si es entero
                        else if (Regex.IsMatch(palabras[i], @"^\d{0,10}"))
                        {
                            dtgVariables.Rows.Add("CONT" + contenido, "Entero", "CONT" + contenido, palabras[i]);
                        }
                    }
                    //Numeros adentro de parentesis
                    else if (i != 0 && (palabras[i - 1] == "(" && Regex.IsMatch(palabras[i], @"^[0-9]+$")) || (Regex.IsMatch(palabras[i], @"^[0-9]+$") && palabras[i + 1] == ")"))
                    {
                        txtTokens.AppendText("NUM ");
                    }
                    //Si nada de lo anterior concuerda entonces es ERROR DE SINTAXIS
                    else
                    {

                        txtTokens.AppendText("SINTAX_ERROR ");
                    }

                }
                catch (Exception)
                {

                    continue;
                }


            }
            //Recopilacion de Errores y escritos en dtgErrores
            fila = 0;
            int numpal = 0;
            foreach (var item in txtTokens.Lines)
            {
                numpal = 0;
                fila++;
                string[] filadata = item.Split();

                foreach (var err in filadata)
                {
                    numpal++;
                    if (err == "SINTAX_ERROR")
                    {
                        dtgErrores.Rows.Add(fila, "SINTAX", "Error en la fila " + fila + " palabra " + numpal);
                    }
                }
            }

        }

        //Funcion donde checa la sintaxis y validacion de concordancia entre tipo de dato y contenido del dato Ejemplo: int a = "Hola" <-- Esto es lo que revisa esta funcion
        public bool CheckSintaxis(string tipo,string[] data,int palabra)
        {
            string nombre = data.ElementAt(palabra);
            string igual = data.ElementAt(palabra + 1);
            string valor = data.ElementAt(palabra + 2);

            char[] charArray = nombre.ToCharArray();
            string first = charArray[0].ToString();

            if (igual != "=" && !Regex.IsMatch(first, @"^[0-9]+$"))
            {
                return false;
            }

            switch (tipo)
            {
                case "int":
                    if (Regex.IsMatch(valor, @"^[0-9]+$") )
                    {
                        return true;
                    }
                    else if (CheckVariable(valor) != "null")
                    {
                        return true;
                    }
                    return false;

                case "string":
                    if (!Regex.IsMatch(valor, @"^[0-9]\d{0,10} +$"))
                    {
                        return true;
                    }
                    return false;

                case "bool":
                    if (valor == "true" || valor == "false" || valor == "t" || valor == "f" || valor == "TRUE" || valor == "FALSE" || valor == "T" || valor == "F")
                    {
                        return true;
                    }
                    return false;

                case "double":
                    if (Regex.IsMatch(valor, @"^\d{0,10}[.]\d{0,10}"))
                    {
                        return true;
                    }
                    return false;

                case "const":
                    return true;

                default:
                    return false;
            }
        }

        //Cada vez que el programa detecte un enter se suman los numeros de la izquierda
        int ICodigo = 0;
        private void txtFuente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtNumLineaFuente.AppendText(ICodigo + "\n");
                txtLineaTokens.AppendText(ICodigo + "\n");
                ICodigo++;
            }
            else if (e.KeyChar == (char)8 && txtFuente.Lines.Length == ICodigo - 1)
            {
                txtLineaTokens.Clear();
                txtNumLineaFuente.Clear();
                ICodigo--;
                for (int i = 0; i < ICodigo; i++)
                {
                    txtNumLineaFuente.AppendText(i + "\n");
                    txtLineaTokens.AppendText(i + "\n");
                }
            }
        }
        //Carga de archivos .xd para el codigo fuente
        private void abriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 0;
            ICodigo = 0;
            txtFuente.Text = "";
            txtTokens.Text = "";
            txtLineaTokens.Text = "";
            txtNumLineaFuente.Text = "";

            dtgErrores.Rows.Clear();
            dtgSimbolos.Rows.Clear();
            dtgVariables.Rows.Clear();

            string linea, archivo;
            txtFuente.Clear();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos xd|*.xd";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader streamReader = new StreamReader(openFile.FileName);
                    linea = streamReader.ReadLine();
                    do
                    {

                        txtFuente.AppendText(linea + "\r\n");
                        ICodigo++;
                        txtNumLineaFuente.AppendText(ICodigo + "\r\n");
                        txtLineaTokens.AppendText(ICodigo + "\r\n");
                        linea = streamReader.ReadLine();
                        if (linea == "")
                        {
                            linea = streamReader.ReadLine();

                        }

                    } while (linea != null);
                    txtFuente.Text = txtFuente.Text.Substring(0, txtFuente.Text.Length - 1);
                    archivo = openFile.SafeFileName;
                    streamReader.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            }
        }

        int id = 1;

        //Contador de registros en la tabla de simbolos
        private void dtgSimbolos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            id++;
        }
        //Guardado de codigo Fuente en archivos .xd
        private void programaFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtFuente.Text == "")
            {
                MessageBox.Show("No ha sido posible guardar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Archivos xd|*.xd";
            if (SaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamWriter SW = new StreamWriter(SaveFile.FileName);
                    for (int i = 0; i < txtFuente.Lines.Count(); i++)
                    {
                        SW.WriteLine(txtFuente.Lines[i]);
                    }
                    SW.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //Guardado de Tokens en txt
        private void tokensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTokens.Text == "")
            {
                MessageBox.Show("No ha sido posible guardar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Archivos txt|*.txt";
            if (SaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamWriter SW = new StreamWriter(SaveFile.FileName);
                    for (int i = 0; i < txtTokens.Lines.Count(); i++)
                    {
                        SW.WriteLine(txtTokens.Lines[i]);
                    }
                    SW.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //Guardado de tabla de Simbolos en txt
        private void tablaDeSimbolosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgSimbolos.RowCount == 0)
            {
                MessageBox.Show("No ha sido posible guardar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Archivos txt|*.txt";
            if (SaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamWriter SW = new StreamWriter(SaveFile.FileName);
                    for (int i = 0; i < dtgSimbolos.RowCount; i++)
                    {
                        for (int j = 0; j < dtgSimbolos.ColumnCount; j++)
                        {
                            SW.WriteLine(dtgSimbolos.Rows[i].Cells[j].Value);
                        }
                        SW.WriteLine("\n");
                    }
                    SW.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //Forma que muestra el Acerca De
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AcercaDe acercade = new AcercaDe();
            acercade.Show();
        }
        //Limpia todo el programa
        private void limpiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 0;
            ICodigo = 0;
            txtFuente.Text = "";
            txtTokens.Text = "";
            txtLineaTokens.Text = "";
            txtNumLineaFuente.Text = "";

            dtgErrores.Rows.Clear();
            dtgSimbolos.Rows.Clear();
            dtgVariables.Rows.Clear();
        }
        //Modo Oscuro
        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            menuStrip1.BackColor = Color.DimGray;
            btnAnalisisLexico.BackColor = Color.Black;
            btnAnalisisLexico.ForeColor = Color.Lime;

            dtgErrores.BackgroundColor = Color.Black;
            dtgSimbolos.BackgroundColor = Color.Black;
            dtgVariables.BackgroundColor = Color.Black;

            dtgErrores.DefaultCellStyle.ForeColor = Color.Lime;
            dtgSimbolos.DefaultCellStyle.ForeColor = Color.Lime;
            dtgVariables.DefaultCellStyle.ForeColor = Color.Lime;

            dtgErrores.DefaultCellStyle.BackColor = Color.Black;
            dtgSimbolos.DefaultCellStyle.BackColor = Color.Black;
            dtgVariables.DefaultCellStyle.BackColor = Color.Black;

            dtgErrores.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dtgSimbolos.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dtgVariables.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            dtgErrores.DefaultCellStyle.SelectionForeColor = Color.Black;
            dtgSimbolos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dtgVariables.DefaultCellStyle.SelectionForeColor = Color.Black;

            txtFuente.BackColor = Color.Black;
            txtTokens.BackColor = Color.Black;
            txtLineaTokens.BackColor = Color.Black;
            txtNumLineaFuente.BackColor = Color.Black;

            txtFuente.ForeColor = Color.Lime;
            txtTokens.ForeColor = Color.Lime;
            txtLineaTokens.ForeColor = Color.Lime;
            txtNumLineaFuente.ForeColor = Color.Lime;
        }
        //Modo Claro
        private void claroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            menuStrip1.BackColor = Color.LightGray;
            btnAnalisisLexico.BackColor = Color.White;
            btnAnalisisLexico.ForeColor = Color.Black;

            dtgErrores.BackgroundColor = Color.DarkGray;
            dtgSimbolos.BackgroundColor = Color.DarkGray;
            dtgVariables.BackgroundColor = Color.DarkGray;

            dtgErrores.DefaultCellStyle.ForeColor = Color.Black;
            dtgSimbolos.DefaultCellStyle.ForeColor = Color.Black;
            dtgVariables.DefaultCellStyle.ForeColor = Color.Black;

            dtgErrores.DefaultCellStyle.BackColor = Color.DarkGray;
            dtgSimbolos.DefaultCellStyle.BackColor = Color.DarkGray;
            dtgVariables.DefaultCellStyle.BackColor = Color.DarkGray;

            dtgErrores.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dtgSimbolos.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dtgVariables.DefaultCellStyle.SelectionBackColor = Color.Blue;

            dtgErrores.DefaultCellStyle.SelectionForeColor = Color.Black;
            dtgSimbolos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dtgVariables.DefaultCellStyle.SelectionForeColor = Color.Black;

            txtFuente.BackColor = Color.Ivory;
            txtTokens.BackColor = Color.Ivory;
            txtLineaTokens.BackColor = Color.Ivory;
            txtNumLineaFuente.BackColor = Color.Ivory;

            txtFuente.ForeColor = Color.Black;
            txtTokens.ForeColor = Color.Black;
            txtLineaTokens.ForeColor = Color.Black;
            txtNumLineaFuente.ForeColor = Color.Black;
        }
        //Es la misma estupidez que limpia todo el programa solo que con validaciones
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que quiere crear uno nuevo?", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                id = 0;
                ICodigo = 0;
                txtFuente.Text = "";
                txtTokens.Text = "";
                txtLineaTokens.Text = "";
                txtNumLineaFuente.Text = "";

                dtgErrores.Rows.Clear();
                dtgSimbolos.Rows.Clear();
                dtgVariables.Rows.Clear();
            }
        }
        //Forma que muestra la documentacion
        private void documentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentacion doc = new Documentacion();
            doc.Show();
        }
        //Guardado de la tabla de variables
        private void tablaDeVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgVariables.RowCount == 0)
            {
                MessageBox.Show("No ha sido posible guardar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Archivos txt|*.txt";
            if (SaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamWriter SW = new StreamWriter(SaveFile.FileName);
                    for (int i = 0; i < dtgVariables.RowCount; i++)
                    {
                        for (int j = 0; j < dtgVariables.ColumnCount; j++)
                        {
                            SW.WriteLine(dtgVariables.Rows[i].Cells[j].Value);
                        }
                        SW.WriteLine("\n");
                    }
                    SW.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
