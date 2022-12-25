class DummyElements: IComparable<DummyElements> {
	readonly string text;
	readonly int _number;

	public DummyElements(string text, int number) {
		this.text = text;
		this._number = number;
	}

	public override string ToString() {
		return $"[{ _number, 3 }] { text }";
	}

	public int CompareTo(DummyElements other) {
		return _number.CompareTo(other._number);
	}
}