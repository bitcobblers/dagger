namespace Dagger.Core;

public abstract class Model
{
    /// <summary>
    /// Gets the query used to generate the model.
    /// </summary>
    /// <returns>The query used to generate the model.</returns>
    public abstract IQueryable<object> GetQuery();
}
