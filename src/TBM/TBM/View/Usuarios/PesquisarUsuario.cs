﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.Usuarios
{
    public partial class PesquisarUsuario : Form
    {
        Controller.UsuarioController control = new Controller.UsuarioController();
        BL.BLUsuario bl_usr = new BL.BLUsuario(null);
        List<Model.Usuario> usuarios = new List<Model.Usuario>();
        public PesquisarUsuario()
        {
            InitializeComponent();
        }

        private void PesquisarUsuario_Load(object sender, EventArgs e)
        {
            usuarios = bl_usr.carregarUsuarios();
            dgvUsuarios.Rows.Clear();
            control.carregarDgv(usuarios, dgvUsuarios);
            cbFiltros.SelectedIndex = 0;
        }

        private void tbSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPequisa_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            control.carregarDgv(bl_usr.carregarUsuarios(cbFiltros.Text,
                tbSrc.Text.ToUpper()), dgvUsuarios);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = dgvUsuarios.SelectedRows[0].Index;

            if (index >= 0 && index < usuarios.Count)
            {
                DialogResult dr = MessageBox.Show("Deseja realmente desativar o usuário selecionado? ele perderá acesso ao sistema",
                "Confirma Desativação?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    bl_usr.excluirUsuario(usuarios[dgvUsuarios.SelectedRows[0].Index]);
                    dgvUsuarios.Rows.Clear();
                    control.carregarDgv(bl_usr.carregarUsuarios(cbFiltros.Text,
                    tbSrc.Text), dgvUsuarios);
                }
            }else
                control.showInfoMessageBox("Um usuário deve ser selecionado!", "Aviso");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int index = dgvUsuarios.SelectedRows[0].Index;
            if (index >= 0 && index < usuarios.Count)
            {
                if (usuarios[index].Ativado)
                {
                    FrmCadastrarUsuario.usu_escolhido = usuarios[index];
                    new FrmCadastrarUsuario().ShowDialog();
                    FrmCadastrarUsuario.usu_escolhido = null;
                }
                else
                    control.showInfoMessageBox("Não é possível alterar um usuário desativado", "Aviso");
            }
            else
                control.showInfoMessageBox("Um usuário deve ser selecionado!", "Aviso");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmCadastrarUsuario().ShowDialog();
            dgvUsuarios.Rows.Clear();
            usuarios = bl_usr.carregarUsuarios(cbFiltros.Text,
                    tbSrc.Text);
            control.carregarDgv(usuarios, dgvUsuarios);
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            int index = dgvUsuarios.SelectedRows[0].Index;

            if (index >= 0 && index < usuarios.Count)
            {
                DialogResult dr = MessageBox.Show("Deseja realmente reativar o usuário selecionado?",
                "Confirma Ativação?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    bl_usr.ativarUsuario(usuarios[dgvUsuarios.SelectedRows[0].Index]);
                    dgvUsuarios.Rows.Clear();
                    control.carregarDgv(bl_usr.carregarUsuarios(cbFiltros.Text,
                    tbSrc.Text), dgvUsuarios);
                }
            }
            else
                control.showInfoMessageBox("Um usuário deve ser selecionado!", "Aviso");
        }
    }
 }
