class Program {
	static void Main(string[] args) {
		var dummyElementsArray = new DummyElements[] {
			new(text: "Justin Timberlake", number: 5),
			new(text: "Curtis Jackson", number: 10),
			new(text: "Ice Cube", number: 30),
			new(text: "Xzibit", number: 25),
			new(text: "Dr.Dre", number: 40),
			new(text: "Snoop Dogg", number: 20),
			new(text: "Obie Trice", number: 20),
			new(text: "Eminem", number: -5),
			new(text: "Hittman", number: 50)
		};

		Heap<DummyElements> dummyHeapSorted = new Heap<DummyElements>(dummyElementsArray);

		Console.WriteLine(
			"Вывод отсортированного массива с помощью Heap Sort (Пирамидальная) [max-heap, по убыванию]:"
		);
		
		while (dummyHeapSorted.size > 0) {
			DummyElements entry = dummyHeapSorted.extractMax();
			Console.WriteLine(entry);
		}
	}
}
