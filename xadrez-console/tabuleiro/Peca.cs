namespace tabuleiro;
internal abstract class Peca
{
    public Posicao posicao { get; set; }
    public Cor cor { get; protected set; }
    public int qteMovimentos { get; protected set; }
    public Tabuleiro tab { get; protected set; }

    public Peca(Tabuleiro tab, Cor cor)
    {
        this.posicao = null;
        this.cor = cor;
        this.tab = tab;
        qteMovimentos = 0;
    }

    public abstract bool[,] movimentosPossíveis();   

    public Peca(Cor cor, Tabuleiro tab)
    {
        this.cor = cor;
        this.tab = tab;
    }

    public bool existeMovimentosPossiveis()
    {
        bool[,] mat = movimentosPossíveis();
        for (int i=0; i<tab.Linhas; i++)
        {
            for (int j=0; j<tab.Colunas; j++)
            {
                if (mat[i, j])
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool podeMoverPara(Posicao pos)
    {
        return movimentosPossíveis()[pos.Linha, pos.Coluna];
    }

    public void incrementarQteMovimentos()
    {
        qteMovimentos++;
    }
}
