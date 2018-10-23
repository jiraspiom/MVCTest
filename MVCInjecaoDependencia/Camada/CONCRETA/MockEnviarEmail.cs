using Camada.INTERFACE;

namespace Camada.CONCRETA
{
    class MockEnviarEmail : IEnviarEmail
    {
        public string EnviarEmail(string para)
        {
            return string.Format("Mock de email para, {0}", para);
        }
    }
}
