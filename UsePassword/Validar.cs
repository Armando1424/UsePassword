using System;
using System.Windows.Forms;


namespace UsePassword
{
    class Validar
    {
        public void Letras(KeyPressEventArgs e)//solo acepta letras 
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal :(", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void numeros(KeyPressEventArgs e)//solo acepta numeros 
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled=true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal :(", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void NameOfPerson(string name, KeyPressEventArgs e)//acepta solo este formato="letras. letras" ejem: Ing. Mejia
        {
            try
            {
                name += e.KeyChar;
                if (name[0].Equals('.') || name[0].Equals(' '))
                {
                    e.Handled = true;
                }
                else if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals('.') || e.KeyChar.Equals(' '))
                {
                    int dot = 0, separator = 0;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (name[i].Equals('.'))
                        {
                            dot++;
                            if (dot > 1)
                            {
                                e.Handled = true;
                            }
                        }

                        if (name[i].Equals(' '))
                        {
                            separator++;
                            if (separator > 1)
                            {
                                e.Handled = true;
                            }

                            if (!name[i - 1].Equals('.'))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Algo salio mal :(",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void NumbersWithDecimal(string quantity, KeyPressEventArgs e)//acepta numeros decimales ejem: 2.4 pero no espacios
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (e.KeyChar.Equals('.'))
                {
                    quantity += e.KeyChar;
                    int dot = 0;
                    for (int i = 0; i < quantity.Length; i++)
                    {
                        if (quantity[i].Equals('.'))
                        {
                            dot++;
                            if (dot > 1)
                            {
                                e.Handled = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NumbersAndLetters(string numLet, KeyPressEventArgs e)//acepta numeros y letras, pero con solo 1 espacio de separacion
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals(' '))
                {
                    numLet += e.KeyChar;
                    for (int i = 0; i < numLet.Length; i++)
                    {
                        if (i != numLet.Length - 1)
                        {
                            if (numLet[i].Equals(' ') && numLet[i + 1].Equals(' '))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Age(string age, KeyPressEventArgs e)//valida que el usuario este en un rango de 0 a 100 de edad sin espacios o letras
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    age += e.KeyChar;
                    if (Convert.ToInt32(age) > 0 && Convert.ToInt32(age) <= 100)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal :(", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void LettersWithOneSpace(string words, KeyPressEventArgs e)//acepta solo letras pero con un espacio
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals(' '))
                {
                    words += e.KeyChar;
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (i != words.Length - 1)
                        {
                            if (words[i].Equals(' ') && words[i + 1].Equals(' '))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
