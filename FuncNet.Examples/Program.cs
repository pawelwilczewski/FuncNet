using FuncNet;

Union<string, int> small0 = "abc";
Union<string, int> small1 = 42;

// Assert.True(small0.Is0);
// Assert.True(small1.Is1);

Union<string, int> cross0 = Union<int, string>.FromT0(42);
Union<string, int> cross1 = Union<int, string>.FromT1("abc");

// Assert.True(cross0.Is1);
// Assert.True(cross1.Is0);

Union<string, int, double, bool, float, char> big0 = "abc";

Union<string, int, double, bool, float, char> big1 = 42;
Union<string, int, double, bool, float, char> big2 = Union<string, int>.FromT0("abc");

Union<string, int, double, bool, float, char> big3 = Union<string, int>.FromT1(42);
Union<string, int, double, bool, float, char> big4 = Union<string, double, int, bool, char>.FromT1(3.14);

//
// Assert.True(big0.Is0);
// Assert.True(big1.Is1);
// Assert.True(big2.Is0);
// Assert.True(big3.Is1);
// Assert.True(big4.Is2);
//
Union<string, int, double, bool, float, char> permuted2_0 = Union<int, string>.FromT0(42);
Union<string, int, double, bool, float, char> permuted2_1 = Union<string, int>.FromT0("abc");

//
// Assert.True(permuted2_0.Is1);
// Assert.True(permuted2_1.Is0);
//
Union<string, int, double, bool, float, char> permuted3_0 = Union<double, string, int>.FromT0(3.14);
Union<string, int, double, bool, float, char> permuted3_1 = Union<int, double, string>.FromT0(42);
Union<string, int, double, bool, float, char> permuted3_2 = Union<string, double, int>.FromT1(3.14);

//
// Assert.True(permuted3_0.Is2);
// Assert.True(permuted3_1.Is1);
// Assert.True(permuted3_2.Is2);
//
Union<string, int, double, bool, float, char> permuted4_0 = Union<bool, int, string, double>.FromT0(true);
Union<string, int, double, bool, float, char> permuted4_1 = Union<double, bool, int, string>.FromT2(42);
Union<string, int, double, bool, float, char> permuted4_2 = Union<string, double, bool, int>.FromT3(42);

//
// Assert.True(permuted4_0.Is3);
// Assert.True(permuted4_1.Is1);
// Assert.True(permuted4_2.Is1);
//
Union<int, string> intermediate = Union<string, int>.FromT1(42);
Union<string, int, double, bool, float, char> multiHop = intermediate;

//
// Assert.True(intermediate.Is0);
// Assert.True(multiHop.Is1);
//
Union<string, int> originalUnion = 42;
Union<string, int, double> convertedUnion = originalUnion;

//
// Assert.Equal(originalUnion.Is1, convertedUnion.Is1);

Union<int, string, float, double, DateTime, bool, char, long> Method() =>
	Union<double, int, string, char, float, DateTime>.FromT2("Fdfsdf");