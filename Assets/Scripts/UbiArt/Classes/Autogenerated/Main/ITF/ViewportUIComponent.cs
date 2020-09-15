using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ViewportUIComponent : ActorComponent {
		public View view;
		public bool active;
		public uint visibilityRequiredFlags;
		public uint visibilityRejectFlags;
		public float focale;
		public float farPlane;
		public float viewportDefinitionLeft;
		public float viewportDefinitionRight;
		public float viewportDefinitionTop;
		public float viewportDefinitionBottom;
		public Vec2d viewportPosition;
		public Vec2d viewportSize;
		public float viewportRotation;
		public Path frameTexturePath;
		public int frameShiftOutLeft;
		public int frameShiftOutTop;
		public int frameShiftOutRight;
		public int frameShiftOutBottom;
		public int frameSizeLeft;
		public int frameSizeTop;
		public int frameSizeRight;
		public int frameSizeBottom;
		public float zOrder;
		public GFX_VIEW_ZPASS ZPassOverride;
		public float updateFrustumEnlargeRange;
		public float loadingFrustumEnlargeRange;
		public string parentViewName;
		public bool clearViewport;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			view = s.Serialize<View>(view, name: "view");
			active = s.Serialize<bool>(active, name: "active");
			visibilityRequiredFlags = s.Serialize<uint>(visibilityRequiredFlags, name: "visibilityRequiredFlags");
			visibilityRejectFlags = s.Serialize<uint>(visibilityRejectFlags, name: "visibilityRejectFlags");
			focale = s.Serialize<float>(focale, name: "focale");
			farPlane = s.Serialize<float>(farPlane, name: "farPlane");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				viewportDefinitionLeft = s.Serialize<float>(viewportDefinitionLeft, name: "viewportDefinitionLeft");
				viewportDefinitionRight = s.Serialize<float>(viewportDefinitionRight, name: "viewportDefinitionRight");
				viewportDefinitionTop = s.Serialize<float>(viewportDefinitionTop, name: "viewportDefinitionTop");
				viewportDefinitionBottom = s.Serialize<float>(viewportDefinitionBottom, name: "viewportDefinitionBottom");
			}
			viewportPosition = s.SerializeObject<Vec2d>(viewportPosition, name: "viewportPosition");
			viewportSize = s.SerializeObject<Vec2d>(viewportSize, name: "viewportSize");
			viewportRotation = s.Serialize<float>(viewportRotation, name: "viewportRotation");
			frameTexturePath = s.SerializeObject<Path>(frameTexturePath, name: "frameTexturePath");
			frameShiftOutLeft = s.Serialize<int>(frameShiftOutLeft, name: "frameShiftOutLeft");
			frameShiftOutTop = s.Serialize<int>(frameShiftOutTop, name: "frameShiftOutTop");
			frameShiftOutRight = s.Serialize<int>(frameShiftOutRight, name: "frameShiftOutRight");
			frameShiftOutBottom = s.Serialize<int>(frameShiftOutBottom, name: "frameShiftOutBottom");
			frameSizeLeft = s.Serialize<int>(frameSizeLeft, name: "frameSizeLeft");
			frameSizeTop = s.Serialize<int>(frameSizeTop, name: "frameSizeTop");
			frameSizeRight = s.Serialize<int>(frameSizeRight, name: "frameSizeRight");
			frameSizeBottom = s.Serialize<int>(frameSizeBottom, name: "frameSizeBottom");
			zOrder = s.Serialize<float>(zOrder, name: "zOrder");
			ZPassOverride = s.Serialize<GFX_VIEW_ZPASS>(ZPassOverride, name: "ZPassOverride");
			updateFrustumEnlargeRange = s.Serialize<float>(updateFrustumEnlargeRange, name: "updateFrustumEnlargeRange");
			loadingFrustumEnlargeRange = s.Serialize<float>(loadingFrustumEnlargeRange, name: "loadingFrustumEnlargeRange");
			parentViewName = s.Serialize<string>(parentViewName, name: "parentViewName");
			clearViewport = s.Serialize<bool>(clearViewport, name: "clearViewport");
		}
		public enum View {
			[Serialize("View::None"            )] None = 0,
			[Serialize("View::Main"            )] Main = 1,
			[Serialize("View::Remote"          )] Remote = 2,
			[Serialize("View::MainAndRemote"   )] MainAndRemote = 3,
			[Serialize("View::MainOnly"        )] MainOnly = 4,
			[Serialize("View::RemoteOnly"      )] RemoteOnly = 5,
			[Serialize("View::RemoteAsMainOnly")] RemoteAsMainOnly = 6,
			[Serialize("View::All"             )] All = -1,
		}
		public enum GFX_VIEW_ZPASS {
			[Serialize("GFX_VIEW_ZPASS_DEFAULT"        )] DEFAULT = 0,
			[Serialize("GFX_VIEW_ZPASS_FORCE_USE_ZPASS")] FORCE_USE_ZPASS = 1,
			[Serialize("GFX_VIEW_ZPASS_FORCE_NO_ZPASS" )] FORCE_NO_ZPASS = 2,
		}
		public override uint? ClassCRC => 0x6990834C;
	}
}

