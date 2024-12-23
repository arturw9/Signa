using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("PESSOA")]
public class Pessoa
{
    [Key]
    [Column("PESSOA_ID")]
    public int PessoaId { get; set; }

    [Column("NOME_FANTASIA")]
    public string NomeFantasia { get; set; }

    [Column("CNPJ_CPF")]
    public string CnpjCpf { get; set; }
}