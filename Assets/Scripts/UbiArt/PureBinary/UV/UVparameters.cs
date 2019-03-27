using UnityEngine;

namespace UbiArt.UV {
	public class UVparameters : CSerializable {
		[Serialize("unkFloat")] public float unkFloat;
		[Serialize("unkString")] public string unkString;
		[Serialize("parameters")] public CArray<Parameters> parameters;
		[Serialize("triangles")] public CArray<Triangle> triangles;

		protected override void SerializeImpl(CSerializerObject s) {
			SerializeField(s, nameof(unkFloat));
			SerializeField(s, nameof(unkString));
			SerializeField(s, nameof(parameters));
			SerializeField(s, nameof(triangles));
		}
		public class Triangle : CSerializable {
			[Serialize("vertex1")] public int vertex1;
			[Serialize("vertex2")] public int vertex2;
			[Serialize("vertex3")] public int vertex3;
			protected override void SerializeImpl(CSerializerObject s) {
				SerializeField(s, nameof(vertex1));
				SerializeField(s, nameof(vertex2));
				SerializeField(s, nameof(vertex3));
			}
		}
		public class Parameters : CSerializable {
			[Serialize("x")] public float x;
			[Serialize("y")] public float y;
			protected override void SerializeImpl(CSerializerObject s) {
				SerializeField(s, nameof(x));
				SerializeField(s, nameof(y));
			}
		}
	}
}
