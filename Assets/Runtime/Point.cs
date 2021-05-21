namespace ColliderMasking
{
	public class Point
	{
		#region FIELDS

		public float x, y;
		public Point prev;
		public Point next;
		public Point copy;
		public float alpha;
		public bool isEntry;
		public bool isIntersection;

		#endregion

		#region CONSTRUCTORS

		public Point(float x, float y) {
			this.x = x; this.y = y;
		}

		#endregion
	}
}
