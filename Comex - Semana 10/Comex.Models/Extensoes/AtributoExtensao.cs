using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comex.Comex.Models.Extensoes
{
    // Classes e métodos de extensoes devem ser estáticas
    public static class AtributoExtensao
    {
        public static string ExtrairTamanho(this string atributos)
        {
            var tamanho = Regex.Match(atributos, @"(?<=tamanho:\s?)[a-z]", RegexOptions.IgnoreCase);
            // Ignorando as possíveis formas de grafia da palavra tamanho
            return tamanho.Value.Trim();
            // Remove apenas os espaços em branco à esquerda e à direita. Não remove espaços em branco que aparecem no meio.
        }

        public static string ExtrairCor(this string atributos)
        {
            var cor = Regex.Match(atributos, @"(?<=cor:\s?)\w+", RegexOptions.IgnoreCase);
            return cor.Value.Trim();
        }
    }
}
