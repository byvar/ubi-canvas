namespace UbiArt.Animation {
	// See: ITF::AnimTrackBonePAS::serialize
	public class AnimTrackBonePAS : CSerializable {
		public ushort frame;
		public short posX;
		public short posY;
		public short angle;
		public short scaleX;
		public short scaleY;

		public Bone3D angle3D;
		public Bone3D pos3D;
		public Bone3D pos2_3D;
		public uint col_unknown;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Context.Settings.Game == Game.COL) {
				frame = s.Serialize<ushort>(frame, name: nameof(frame));
				angle3D = s.SerializeObject<Bone3D>(angle3D, name: nameof(angle3D));
				pos3D = s.SerializeObject<Bone3D>(pos3D, name: nameof(pos3D));
				pos2_3D = s.SerializeObject<Bone3D>(pos2_3D, name: nameof(pos2_3D));
				scaleX = s.Serialize<short>(scaleX, name: nameof(scaleX));
				scaleY = s.Serialize<short>(scaleY, name: nameof(scaleY));
				col_unknown = s.Serialize<uint>(col_unknown, name: nameof(col_unknown));
			} else {
				frame = s.Serialize<ushort>(frame, name: nameof(frame));
				angle = s.Serialize<short>(angle, name: nameof(angle));
				posX = s.Serialize<short>(posX, name: nameof(posX));
				posY = s.Serialize<short>(posY, name: nameof(posY));
				scaleX = s.Serialize<short>(scaleX, name: nameof(scaleX));
				scaleY = s.Serialize<short>(scaleY, name: nameof(scaleY));
			}
		}

		public class Bone3D : CSerializable {
			public short X { get; set; }
			public short Y { get; set; }
			public short Z { get; set; }

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				X = s.Serialize<short>(X, name: nameof(X));
				Y = s.Serialize<short>(Y, name: nameof(Y));
				Z = s.Serialize<short>(Z, name: nameof(Z));
			}
		}

		public Vec2d Position {
			get => new Vec2d(posX * OneOverShortMax, posY * OneOverShortMax);
			set {
				posX = (short)(value.x / OneOverShortMax);
				posY = (short)(value.y / OneOverShortMax);
			}
		}
		public Vec2d Scale {
			get => new Vec2d(scaleX * OneOverShortMax, scaleY * OneOverShortMax);
			set {
				scaleX = (short)(value.x / OneOverShortMax);
				scaleY = (short)(value.y / OneOverShortMax);
			}
		}
		public Angle Rotation => angle * OneOverShortMax;

		public const float OneOverShortMax = 0.000030518f;

		/*
		Example (from yellow_afraid_to_red_afraid.anm.ckd):
		0000 E7A4 1D90 0AFD 3A66 2C61
		0000 7EBB 99C2 EAB6 3BBE 2C22
		0000 0000 0000 0000 62AD 62AD
		0002 0E21 F6FC F917 62AD 62AD
		0003 0E21 F6FC F917 62AD 62AD
		0005 0000 0000 0000 62AD 62AD
		0006 0000 0000 0000 62AD 62AD
		0008 0E21 F6FC F917 62AD 62AD
		0009 0E21 F6FC F917 62AD 62AD
		000B 0000 0000 0000 62AD 62AD
		000C 0000 0000 0000 62AD 62AD
		000E 0E21 F6FC F917 62AD 62AD
		000F 0E21 F6FC F917 62AD 62AD
		0011 0000 0000 0000 62AD 62AD
		0000 F634 E618 F27C 62AD 62AD
		0001 F97C ED9E 0EB4 57C1 70B4
		0003 FC4B F412 26E4 4E64 7CBA
		0008 FCC3 F525 2AEC 4CD5 7EBB
		0009 F9D9 EE75 11D6 568A 7243
		000B F614 E7FA E914 6B72 5AA0
		000E F62F E668 F0EB 6423 6156
		0011 F634 E618 F27C 62AD 62AD
		*/
	}
}
