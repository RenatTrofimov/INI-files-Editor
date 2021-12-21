using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab_5
{

    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    class INIBlock
    {
        public INIBlock(string name)
        {
            this.name = name;
            Property = new LinkedList<INIProperty>();
        }

        public String name { get; set; }
        public LinkedList<INIProperty> Property { get; set; }
    }
    class INIProperty
    {
        public INIProperty()
        {
            this.name = "";
            this.data = "";
        }
        public INIProperty(string name, string data)
        {
            this.name = name;
            this.data = data;
        }

        public String name { get; set; }
        public String data { get; set; }
    }
    public class LinkedList<T> : IEnumerable<T>  // односвязный список
    {
        Node<T> head;
        Node<T> tail;
        int count; 
        public LinkedList()
        {
            head = tail = null;
            count = 0;
        }
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                       
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void Read()
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    public partial class BlockEditor : Form
    {
        public BlockEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Renas\\source\\repos\\Lab_5";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();
                
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    
                    int countBlock = 0;
                    
                    while (!reader.EndOfStream)
                    {
                        String str = reader.ReadLine();
                        LinkedList<INIBlock> Blocks = new LinkedList<INIBlock>();
                        if (str.Contains("[\"")&& str.Contains("\"]"))
                        {
                            Blocks.Add(new INIBlock("0"));
                        }
                        if (str.Contains("="))
                        {
                            string[] words = str.Split(new char[] { '=' });
                        
                        }
                    }
                    filePathTextBox.Text = countBlock.ToString();
                }
                
            }
        }

        private void AddBlockBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBlockBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddFieldBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFieldBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditFieldBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
