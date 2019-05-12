using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class PhysForceModifier : CSerializable {
		[Serialize("force"                 )] public Vector2 force;
		[Serialize("offset"                )] public Vector2 offset;
		[Serialize("rotation"              )] public Angle rotation;
		[Serialize("centerForce"           )] public float centerForce;
		[Serialize("centerForceMaxSpeed"   )] public float centerForceMaxSpeed;
		[Serialize("centerForceSpeed2Force")] public float centerForceSpeed2Force;
		[Serialize("gradientPercentage"    )] public float gradientPercentage;
		[Serialize("speedMultiplierX"      )] public float speedMultiplierX;
		[Serialize("speedMultiplierY"      )] public float speedMultiplierY;
		[Serialize("point"                 )] public int point;
		[Serialize("inverted"              )] public int inverted;
		[Serialize("Type"                  )] public TYPE Type;
		[Serialize("Box"                   )] public PhysForceModifier.BoxData Box;
		[Serialize("PolyLine"              )] public PhysForceModifier.PolylineData PolyLine;
		[Serialize("Circle"                )] public PhysForceModifier.CircleData Circle;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(force));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(rotation));
			SerializeField(s, nameof(centerForce));
			SerializeField(s, nameof(centerForceMaxSpeed));
			SerializeField(s, nameof(centerForceSpeed2Force));
			SerializeField(s, nameof(gradientPercentage));
			SerializeField(s, nameof(speedMultiplierX));
			SerializeField(s, nameof(speedMultiplierY));
			SerializeField(s, nameof(point));
			SerializeField(s, nameof(inverted));
			SerializeField(s, nameof(Type));
			switch (Type) {
				case TYPE.BOX:
					SerializeField(s, nameof(Box));
					break;
				case TYPE.CIRCLE:
					SerializeField(s, nameof(Circle));
					break;
				case TYPE.POLYLINE:
					SerializeField(s, nameof(PolyLine));
					break;
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class BoxData : CSerializable {
			[Serialize("width" )] public float width;
			[Serialize("height")] public float height;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(height));
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class CircleData : CSerializable {
			[Serialize("radius"    )] public float radius;
			[Serialize("angleStart")] public Angle angleStart;
			[Serialize("angleEnd"  )] public Angle angleEnd;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(radius));
				SerializeField(s, nameof(angleStart));
				SerializeField(s, nameof(angleEnd));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class PolylineData : CSerializable {
			[Serialize("animId")] public StringID animId;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(animId));
			}
		}
		public enum TYPE {
			[Serialize("TYPE_CIRCLE"  )] CIRCLE = 0,
			[Serialize("TYPE_BOX"     )] BOX = 1,
			[Serialize("TYPE_POLYLINE")] POLYLINE = 2,
		}
		public override uint? ClassCRC => 0x4F18F0CF;
	}
}

