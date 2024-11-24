namespace BloodBank.Shared.Responses
{
    /// <summary>
    /// Representa una respuesta estándar utilizada para comunicar el estado de una operación.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Indica si la operación fue exitosa o no.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Contiene un mensaje adicional sobre el resultado de la operación, como detalles de errores o confirmaciones.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Contiene un resultado opcional relacionado con la operación, como datos adicionales.
        /// </summary>
        public object? Result { get; set; }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Response() { }

        /// <summary>
        /// Constructor que inicializa las propiedades principales.
        /// </summary>
        /// <param name="isSuccess">Indica si la operación fue exitosa.</param>
        /// <param name="message">Mensaje adicional sobre el resultado.</param>
        /// <param name="result">Resultado adicional, si aplica.</param>
        public Response(bool isSuccess, string? message = null, object? result = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            Result = result;
        }

        /// <summary>
        /// Devuelve una representación en cadena de la respuesta.
        /// </summary>
        /// <returns>Una cadena que describe el estado de la respuesta.</returns>
        public override string ToString()
        {
            return $"Success: {IsSuccess}, Message: {Message}, Result: {Result}";
        }
    }
}
