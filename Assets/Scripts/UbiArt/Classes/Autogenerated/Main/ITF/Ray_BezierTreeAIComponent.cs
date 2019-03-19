using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BezierTreeAIComponent : GraphicComponent {
		[Serialize("startActivated"                            )] public int startActivated;
		[Serialize("branchSpeed"                               )] public float branchSpeed;
		[Serialize("polylineMode"                              )] public Enum_RJR_0 polylineMode;
		[Serialize("flipTexture"                               )] public int flipTexture;
		[Serialize("branches"                                  )] public CList<Ray_BezierTreeAIComponent.Branch> branches;
		[Serialize("int__0"                                    )] public int int__0;
		[Serialize("float__1"                                  )] public float float__1;
		[Serialize("Enum_RFR_0__2"                             )] public Enum_RFR_0 Enum_RFR_0__2;
		[Serialize("int__3"                                    )] public int int__3;
		[Serialize("CList<Ray_BezierTreeAIComponent.Branch>__4")] public CList<Ray_BezierTreeAIComponent.Branch> CList_Ray_BezierTreeAIComponent_Branch__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(int__0));
					SerializeField(s, nameof(float__1));
					SerializeField(s, nameof(Enum_RFR_0__2));
					SerializeField(s, nameof(int__3));
					SerializeField(s, nameof(CList_Ray_BezierTreeAIComponent_Branch__4));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(startActivated));
					SerializeField(s, nameof(branchSpeed));
					SerializeField(s, nameof(polylineMode));
					SerializeField(s, nameof(flipTexture));
					SerializeField(s, nameof(branches));
				}
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Node : CSerializable {
			[Serialize("Vector3__0" )] public Vector3 Vector3__0;
			[Serialize("float__1"   )] public float float__1;
			[Serialize("float__2"   )] public float float__2;
			[Serialize("float__3"   )] public float float__3;
			[Serialize("StringID__4")] public StringID StringID__4;
			[Serialize("float__5"   )] public float float__5;
			[Serialize("StringID__6")] public StringID StringID__6;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Vector3__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(StringID__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(StringID__6));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Branch : CSerializable {
			[Serialize("CArray<Ray_BezierTreeAIComponent.Node>__0")] public CArray<Ray_BezierTreeAIComponent.Node> CArray_Ray_BezierTreeAIComponent_Node__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(CArray_Ray_BezierTreeAIComponent_Node__0));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x3AFFD116;
	}
}

