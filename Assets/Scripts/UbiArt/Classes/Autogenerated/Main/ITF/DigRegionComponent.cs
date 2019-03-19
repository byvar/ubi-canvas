using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DigRegionComponent : ActorComponent {
		[Serialize("Brush_State"            )] public Action Brush_State;
		[Serialize("Brush_Action"           )] public Action Brush_Action;
		[Serialize("BoxCountX"              )] public uint BoxCountX;
		[Serialize("BoxCountY"              )] public uint BoxCountY;
		[Serialize("BrushRadiusGrid"        )] public int BrushRadiusGrid;
		[Serialize("LightDir"               )] public Vector2 LightDir;
		[Serialize("MergeCount"             )] public int MergeCount;
		[Serialize("Vecto_LengthMax"        )] public float Vecto_LengthMax;
		[Serialize("Smooth_LengthMax"       )] public float Smooth_LengthMax;
		[Serialize("Smooth_ShapeMinSize"    )] public float Smooth_ShapeMinSize;
		[Serialize("Collision_Build"        )] public bool Collision_Build;
		[Serialize("Light_Angle"            )] public Angle Light_Angle;
		[Serialize("Grid_Width"             )] public float Grid_Width;
		[Serialize("Grid_Heigth"            )] public float Grid_Heigth;
		[Serialize("Grid_Unity"             )] public float Grid_Unity;
		[Serialize("Grid_VisualOffset"      )] public float Grid_VisualOffset;
		[Serialize("Particles_Spacing"      )] public float Particles_Spacing;
		[Serialize("Particles_NbPerLocation")] public int Particles_NbPerLocation;
		[Serialize("Regeneration_Speed"     )] public float Regeneration_Speed;
		[Serialize("Regeneration_StartDelay")] public float Regeneration_StartDelay;
		[Serialize("Regeneration_EndDelay"  )] public float Regeneration_EndDelay;
		[Serialize("Regeneration_AccDist"   )] public float Regeneration_AccDist;
		[Serialize("Regeneration_TimeMaxDRC")] public float Regeneration_TimeMaxDRC;
		[Serialize("Uv_Fill"                )] public DigRegionComponent.ParamUV Uv_Fill;
		[Serialize("Uv_Hole"                )] public DigRegionComponent.ParamUV Uv_Hole;
		[Serialize("Brush_ActionFill"       )] public bool Brush_ActionFill;
		[Serialize("Brush_Radius"           )] public float Brush_Radius;
		[Serialize("padBrushRadius"         )] public float padBrushRadius;
		[Serialize("usePadBrushRadius"      )] public bool usePadBrushRadius;
		[Serialize("PrimitiveParameters"    )] public GFXPrimitiveParam PrimitiveParameters;
		[Serialize("Brush_Enabled"          )] public bool Brush_Enabled;
		[Serialize("IsDiggable"             )] public bool IsDiggable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(Brush_State));
				SerializeField(s, nameof(Brush_Action));
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(BoxCountX));
				SerializeField(s, nameof(BoxCountY));
				SerializeField(s, nameof(BrushRadiusGrid));
				SerializeField(s, nameof(LightDir));
				SerializeField(s, nameof(MergeCount));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(Vecto_LengthMax));
					SerializeField(s, nameof(Smooth_LengthMax));
					SerializeField(s, nameof(Smooth_ShapeMinSize));
					SerializeField(s, nameof(Collision_Build));
					SerializeField(s, nameof(Light_Angle));
					SerializeField(s, nameof(Grid_Width));
					SerializeField(s, nameof(Grid_Heigth));
					SerializeField(s, nameof(Grid_Unity));
					SerializeField(s, nameof(Grid_VisualOffset));
					SerializeField(s, nameof(Particles_Spacing));
					SerializeField(s, nameof(Particles_NbPerLocation));
					SerializeField(s, nameof(Regeneration_Speed));
					SerializeField(s, nameof(Regeneration_StartDelay));
					SerializeField(s, nameof(Regeneration_EndDelay));
					SerializeField(s, nameof(Regeneration_AccDist));
					SerializeField(s, nameof(Regeneration_TimeMaxDRC));
					SerializeField(s, nameof(Uv_Fill));
					SerializeField(s, nameof(Uv_Hole));
					SerializeField(s, nameof(Brush_ActionFill));
					SerializeField(s, nameof(Brush_Radius));
					SerializeField(s, nameof(padBrushRadius));
					SerializeField(s, nameof(usePadBrushRadius));
					SerializeField(s, nameof(PrimitiveParameters));
					SerializeField(s, nameof(Brush_Enabled));
				}
			}
			SerializeField(s, nameof(IsDiggable));
		}
		[Games(GameFlags.RA)]
		public partial class ParamUV : CSerializable {
			[Serialize("UseWorldCoord")] public bool UseWorldCoord;
			[Serialize("Offset"       )] public Vector2 Offset;
			[Serialize("Scale"        )] public Vector2 Scale;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(UseWorldCoord));
				SerializeField(s, nameof(Offset));
				SerializeField(s, nameof(Scale));
			}
		}
		public enum Action {
			[Serialize("Action_Dig"   )] Dig = 0,
			[Serialize("Action_Fill"  )] Fill = 1,
			[Serialize("Action_Toggle")] Toggle = 2,
		}
		public override uint? ClassCRC => 0x43BBBB02;
	}
}

