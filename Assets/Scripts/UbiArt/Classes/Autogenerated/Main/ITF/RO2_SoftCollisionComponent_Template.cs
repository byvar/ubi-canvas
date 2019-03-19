using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_SoftCollisionComponent_Template : GraphicComponent_Template {
		[Serialize("CellSpace"     )] public float CellSpace;
		[Serialize("Gravity"       )] public float Gravity;
		[Serialize("MassCoeff"     )] public float MassCoeff;
		[Serialize("Radius"        )] public float Radius;
		[Serialize("DrawParticles" )] public bool DrawParticles;
		[Serialize("DrawGrid"      )] public bool DrawGrid;
		[Serialize("DrawOwnerCells")] public bool DrawOwnerCells;
		[Serialize("DrawCollision" )] public bool DrawCollision;
		[Serialize("Material"      )] public GFXMaterialSerializable Material;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CellSpace));
			SerializeField(s, nameof(Gravity));
			SerializeField(s, nameof(MassCoeff));
			SerializeField(s, nameof(Radius));
			SerializeField(s, nameof(DrawParticles));
			SerializeField(s, nameof(DrawGrid));
			SerializeField(s, nameof(DrawOwnerCells));
			SerializeField(s, nameof(DrawCollision));
			SerializeField(s, nameof(Material));
		}
		public override uint? ClassCRC => 0x451F0B30;
	}
}

