namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class PhysForceModifier : CSerializable {
		public Vec2d force;
		public Vec2d offset;
		public Angle rotation;
		public float centerForce;
		public float centerForceMaxSpeed;
		public float centerForceSpeed2Force;
		public float gradientPercentage;
		public float speedMultiplierX;
		public float speedMultiplierY;
		public int point;
		public int inverted;
		public TYPE Type;
		public PhysForceModifier.BoxData Box;
		public PhysForceModifier.PolylineData PolyLine;
		public PhysForceModifier.CircleData Circle;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			force = s.SerializeObject<Vec2d>(force, name: "force");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
			rotation = s.SerializeObject<Angle>(rotation, name: "rotation");
			centerForce = s.Serialize<float>(centerForce, name: "centerForce");
			centerForceMaxSpeed = s.Serialize<float>(centerForceMaxSpeed, name: "centerForceMaxSpeed");
			centerForceSpeed2Force = s.Serialize<float>(centerForceSpeed2Force, name: "centerForceSpeed2Force");
			gradientPercentage = s.Serialize<float>(gradientPercentage, name: "gradientPercentage");
			speedMultiplierX = s.Serialize<float>(speedMultiplierX, name: "speedMultiplierX");
			speedMultiplierY = s.Serialize<float>(speedMultiplierY, name: "speedMultiplierY");
			point = s.Serialize<int>(point, name: "point");
			inverted = s.Serialize<int>(inverted, name: "inverted");
			Type = s.Serialize<TYPE>(Type, name: "Type");
			switch (Type) {
				case TYPE.BOX:
					Box = s.SerializeObject<PhysForceModifier.BoxData>(Box, name: "Box");
					break;
				case TYPE.CIRCLE:
					Circle = s.SerializeObject<PhysForceModifier.CircleData>(Circle, name: "Circle");
					break;
				case TYPE.POLYLINE:
					PolyLine = s.SerializeObject<PhysForceModifier.PolylineData>(PolyLine, name: "PolyLine");
					break;
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class BoxData : CSerializable {
			public float width;
			public float height;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				width = s.Serialize<float>(width, name: "width");
				height = s.Serialize<float>(height, name: "height");
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class CircleData : CSerializable {
			public float radius;
			public Angle angleStart;
			public Angle angleEnd;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				radius = s.Serialize<float>(radius, name: "radius");
				angleStart = s.SerializeObject<Angle>(angleStart, name: "angleStart");
				angleEnd = s.SerializeObject<Angle>(angleEnd, name: "angleEnd");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class PolylineData : CSerializable {
			public StringID animId;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				animId = s.SerializeObject<StringID>(animId, name: "animId");
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

