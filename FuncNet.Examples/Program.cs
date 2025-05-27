namespace FuncNet.Examples;

internal sealed class Program
{
	public static void Main(string[] args)
	{
		var result = CreateUser(
			"John Doe",
			name => string.IsNullOrEmpty(name)
				? new ValidationError("Name can't be empty")
				: name,
			user => Random.Shared.Next() % 2 == 0
				? new DatabaseError("Lost connection")
				: user);

		result.Match(
			user =>
			{
				Console.WriteLine($"User created: {user.Name}");
				return None.Instance;
			},
			validationError =>
			{
				Console.WriteLine($"Validation error: {validationError.Message}");
				return None.Instance;
			},
			databaseError =>
			{
				Console.WriteLine($"Database error: {databaseError.Message}");
				return None.Instance;
			});
	}

	private static Result<User, ValidationError, DatabaseError> CreateUser(
		string name,
		Func<string, Result<string, ValidationError>> validateName,
		Func<User, Result<User, DatabaseError>> saveToDb) =>
		Result<string, ValidationError>.FromSuccess(name)
			.BindSuccess(validateName)
			.MapSuccess(validatedName => new User(validatedName))
			.Extend<User, ValidationError, DatabaseError>()
			.BindSuccess(user => saveToDb(user)
				.Match(
					Result<User, ValidationError, DatabaseError>.FromSuccess,
					databaseError => databaseError));
}

internal readonly record struct User(string Name);

internal readonly record struct ValidationError(string Message);

internal readonly record struct DatabaseError(string Message);