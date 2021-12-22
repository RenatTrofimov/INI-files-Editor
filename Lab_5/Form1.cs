using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class IniEditor : Form
    {
        INIBlock selectedBlock;
        string filePath;
        bool isfile;
        INIManager INIManager;
        public IniEditor()
        {
            InitializeComponent();
            filePath = string.Empty;
            isfile = false;
            INIManager = new INIManager();
            selectedBlock = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Renas\\source\\repos\\Lab_5";
            openFileDialog.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                filePath = openFileDialog.FileName;

                filePathTextBox.Text = filePath;

                INIManager.ReadFile(filePath);

                isfile = true;
                
                MainPanel.Enabled = true;
            }
            setBlockList();
        }
        void setBlockList()
        {
            listOfBlocks.Items.Clear();
            listOfBlocks.DisplayMember = "name";
            foreach (var item in INIManager.Blocks)
            { 
               listOfBlocks.Items.Add(item);
            }
        }
        
        private void AddBlockBtn_Click(object sender, EventArgs e)
        {
            using (var form = new Block())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    INIManager.Blocks.Add(form.output);
                    setBlockList();
                }
            }
            
        }

        private void DeleteBlockBtn_Click(object sender, EventArgs e)
        {
            if (listOfBlocks.SelectedIndex > -1)
            {
                INIManager.Blocks.Remove(INIManager.Blocks.getByIndex(listOfBlocks.SelectedIndex).Data);
                setBlockList();
            }
        }

        private void AddFieldBtn_Click(object sender, EventArgs e)
        {
            using (var form = new Property())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    selectedBlock.Property.Add(form.output);
                    setPropertyList();
                }
            }
        }

        private void DeleteFieldBtn_Click(object sender, EventArgs e)
        {
            if (listOfProperty.SelectedIndex > -1)
            {
                selectedBlock.Property.Remove(selectedBlock.Property.getByIndex(listOfProperty.SelectedIndex).Data);
                setPropertyList();
            }
        }

        private void EditFieldBtn_Click(object sender, EventArgs e)
        {
            if (listOfProperty.SelectedIndex > -1)
            {
                INIProperty temp = selectedBlock.Property.getByIndex(listOfProperty.SelectedIndex).Data;
                using (var form = new Property(temp.name, temp.data))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        selectedBlock.Property.Edit(temp, form.output);
                        setPropertyList();
                    }
                }
            }
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveFileBtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(filePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\Users\\Renas\\source\\repos\\Lab_5";
                saveFileDialog.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = saveFileDialog.FileName;

                    filePathTextBox.Text = filePath;

                }
            }
            INIManager.SaveFile(filePath);
        }
        void setPropertyList()
        {
            listOfProperty.Items.Clear();
            if (listOfBlocks.SelectedIndex > -1)
            {
                listOfProperty.DisplayMember = "name";
                selectedBlock = INIManager.Blocks.getByIndex(listOfBlocks.SelectedIndex).Data;
                foreach (var item in selectedBlock.Property)
                {
                    listOfProperty.Items.Add(item);
                }
            }
            
        }
        private void listOfBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            setPropertyList();
        }

        private void valueTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void listOfProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueTX.Text = selectedBlock.Property.getByIndex(listOfProperty.SelectedIndex).Data.data;
        }

        private void EditBlock_Click(object sender, EventArgs e)
        {
            if (listOfBlocks.SelectedIndex > -1)
            {
                using (var form = new Block(selectedBlock.name))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        INIManager.Blocks.Edit(selectedBlock, form.output);
                        setBlockList();
                    }
                }
            }
        }
    }
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class INIManager
    {
        public LinkedList<INIBlock> Blocks = new LinkedList<INIBlock>();

        public void ReadFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
            {
                String str = reader.ReadLine();

                if (str.Contains("[") && str.Contains("]"))
                {
                    Blocks.Add(new INIBlock(str.Trim('[',']')));
                }
                if (str.Contains("="))
                {
                    string[] words = str.Split(new char[] { '=' });
                    Blocks.GetLast().Property.Add(new INIProperty(words[0], words[1]));
                }
            }
            reader.Close();
        }
        public void SaveFile(string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
            foreach (var block in Blocks)
            {
                writer.WriteLine('['+block.name+']');
                foreach (var property in block.Property)
                {
                    writer.WriteLine(property.name + "=" + property.data);
                }
            }
            writer.Close();
        }
    }
    public class INIBlock
    {
        public INIBlock(string name)
        {
            this.name = name;
            Property = new LinkedList<INIProperty>();
        }

        public String name { get; set; }
        public LinkedList<INIProperty> Property { get; set; }
    }
    public class INIProperty
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
        public Node<T> getByIndex(int Index)
        {

            Node<T> current = head;
            for (int i = 0; i < Index; i++)
            {
                current = current.Next;
            }
            return current;

        }
        public void Edit(T data, T newData)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Data = newData;
                    return;
                }

                current = current.Next;
            }
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
        public T GetLast()
        {
            return tail.Data;
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
}
