using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DigRegionComponent : ActorComponent {
		public Action Brush_State;
		public Action Brush_Action;
		public uint BoxCountX;
		public uint BoxCountY;
		public int BrushRadiusGrid;
		public Vec2d LightDir;
		public int MergeCount;
		public float Vecto_LengthMax;
		public float Smooth_LengthMax;
		public float Smooth_ShapeMinSize;
		public bool Collision_Build;
		public Angle Light_Angle;
		public float Grid_Width;
		public float Grid_Heigth;
		public float Grid_Unity;
		public float Grid_VisualOffset;
		public float Particles_Spacing;
		public int Particles_NbPerLocation;
		public float Regeneration_Speed;
		public float Regeneration_StartDelay;
		public float Regeneration_EndDelay;
		public float Regeneration_AccDist;
		public float Regeneration_TimeMaxDRC;
		public DigRegionComponent.ParamUV Uv_Fill;
		public DigRegionComponent.ParamUV Uv_Hole;
		public bool Brush_ActionFill;
		public float Brush_Radius;
		public float padBrushRadius;
		public bool usePadBrushRadius;
		public GFXPrimitiveParam PrimitiveParameters;
		public bool Brush_Enabled;
		public bool IsDiggable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				Brush_State = s.Serialize<Action>(Brush_State, name: "Brush_State");
				Brush_Action = s.Serialize<Action>(Brush_Action, name: "Brush_Action");
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				BoxCountX = s.Serialize<uint>(BoxCountX, name: "BoxCountX");
				BoxCountY = s.Serialize<uint>(BoxCountY, name: "BoxCountY");
				BrushRadiusGrid = s.Serialize<int>(BrushRadiusGrid, name: "BrushRadiusGrid");
				LightDir = s.SerializeObject<Vec2d>(LightDir, name: "LightDir");
				MergeCount = s.Serialize<int>(MergeCount, name: "MergeCount");
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				Vecto_LengthMax = s.Serialize<float>(Vecto_LengthMax, name: "Vecto_LengthMax");
				Smooth_LengthMax = s.Serialize<float>(Smooth_LengthMax, name: "Smooth_LengthMax");
				Smooth_ShapeMinSize = s.Serialize<float>(Smooth_ShapeMinSize, name: "Smooth_ShapeMinSize");
				Collision_Build = s.Serialize<bool>(Collision_Build, name: "Collision_Build");
				Light_Angle = s.SerializeObject<Angle>(Light_Angle, name: "Light_Angle");
				Grid_Width = s.Serialize<float>(Grid_Width, name: "Grid_Width");
				Grid_Heigth = s.Serialize<float>(Grid_Heigth, name: "Grid_Heigth");
				Grid_Unity = s.Serialize<float>(Grid_Unity, name: "Grid_Unity");
				Grid_VisualOffset = s.Serialize<float>(Grid_VisualOffset, name: "Grid_VisualOffset");
				Particles_Spacing = s.Serialize<float>(Particles_Spacing, name: "Particles_Spacing");
				Particles_NbPerLocation = s.Serialize<int>(Particles_NbPerLocation, name: "Particles_NbPerLocation");
				Regeneration_Speed = s.Serialize<float>(Regeneration_Speed, name: "Regeneration_Speed");
				Regeneration_StartDelay = s.Serialize<float>(Regeneration_StartDelay, name: "Regeneration_StartDelay");
				Regeneration_EndDelay = s.Serialize<float>(Regeneration_EndDelay, name: "Regeneration_EndDelay");
				Regeneration_AccDist = s.Serialize<float>(Regeneration_AccDist, name: "Regeneration_AccDist");
				Regeneration_TimeMaxDRC = s.Serialize<float>(Regeneration_TimeMaxDRC, name: "Regeneration_TimeMaxDRC");
				Uv_Fill = s.SerializeObject<DigRegionComponent.ParamUV>(Uv_Fill, name: "Uv_Fill");
				Uv_Hole = s.SerializeObject<DigRegionComponent.ParamUV>(Uv_Hole, name: "Uv_Hole");
				Brush_ActionFill = s.Serialize<bool>(Brush_ActionFill, name: "Brush_ActionFill");
				Brush_Radius = s.Serialize<float>(Brush_Radius, name: "Brush_Radius");
				padBrushRadius = s.Serialize<float>(padBrushRadius, name: "padBrushRadius");
				usePadBrushRadius = s.Serialize<bool>(usePadBrushRadius, name: "usePadBrushRadius");
				PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
				Brush_Enabled = s.Serialize<bool>(Brush_Enabled, name: "Brush_Enabled");
			}
			IsDiggable = s.Serialize<bool>(IsDiggable, name: "IsDiggable");
		}
		[Games(GameFlags.RA)]
		public partial class ParamUV : CSerializable {
			public bool UseWorldCoord;
			public Vec2d Offset;
			public Vec2d Scale;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				UseWorldCoord = s.Serialize<bool>(UseWorldCoord, name: "UseWorldCoord");
				Offset = s.SerializeObject<Vec2d>(Offset, name: "Offset");
				Scale = s.SerializeObject<Vec2d>(Scale, name: "Scale");
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

