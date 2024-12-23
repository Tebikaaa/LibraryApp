﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;

namespace LibraryUI.Forms.UserControls
{
    public partial class KategoriCard : UserControl
    {
        private readonly Kategori _kategori; // Seçilen kategori
        private readonly Action _listeYenile;
        public KategoriCard(Kategori kategori, Action listeYenile)
        {
            InitializeComponent();
            _kategori = kategori;
            _listeYenile = listeYenile;

            txtKategoriAdi.Text = _kategori.KategoriAdi;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Onay al
                var sonuc = MessageBox.Show($"{_kategori.KategoriAdi} kategorisini silmek istediğinize emin misiniz?",
                                            "Silme Onayı",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    using (var context = new LibraryContext())
                    {
                        // Kategori ile ilişkili kitapları kontrol et
                        bool kitapVarMi = context.Kitaplar.Any(k => k.KategoriID == _kategori.ID);
                        if (kitapVarMi)
                        {
                            MessageBox.Show("Bu kategoriye bağlı kitaplar var. Önce bu kitapları silin!",
                                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Kategoriyi sil
                        var kategori = context.Kategoriler.Find(_kategori.ID);
                        if (kategori != null)
                        {
                            context.Kategoriler.Remove(kategori); // Silme işlemi
                            context.SaveChanges(); // Veritabanına kaydet

                            MessageBox.Show("Kategori başarıyla silindi!", "Başarılı",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Listeyi yenile
                            _listeYenile?.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Kategori bulunamadı!", "Hata",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}