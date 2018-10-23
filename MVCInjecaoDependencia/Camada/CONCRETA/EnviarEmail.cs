using Camada.INTERFACE;

namespace Camada.CONCRETA
{
    class EnviarEmail : IEnviarEmail
    {
        string IEnviarEmail.EnviarEmail(string para)
        {
            return string.Format("Enviar email para, {0}. producao", para);
        }
    }
}
