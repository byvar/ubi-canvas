namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class RequestOptions : CSerializable {
		public bool connectModule;
		public bool retryIfDisconnected;
		public uint maxAutoRetry;
		public float autoRetryDelay;
		public bool notifyErrorRetry;
		public RequestOptions.PopupOptions inProgressPopup;
		public RequestOptions.ErrorPopupOptions errorPopup;
		public RequestOptions.ErrorPopupOptions errorRetryPopup;
		public RequestOptions.PopupOptions successPopup;
		public bool silentConnection;
		public bool needPid;
		public float timeout;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			connectModule = s.Serialize<bool>(connectModule, name: "connectModule");
			retryIfDisconnected = s.Serialize<bool>(retryIfDisconnected, name: "retryIfDisconnected");
			maxAutoRetry = s.Serialize<uint>(maxAutoRetry, name: "maxAutoRetry");
			autoRetryDelay = s.Serialize<float>(autoRetryDelay, name: "autoRetryDelay");
			notifyErrorRetry = s.Serialize<bool>(notifyErrorRetry, name: "notifyErrorRetry");
			inProgressPopup = s.SerializeObject<RequestOptions.PopupOptions>(inProgressPopup, name: "inProgressPopup");
			errorPopup = s.SerializeObject<RequestOptions.ErrorPopupOptions>(errorPopup, name: "errorPopup");
			errorRetryPopup = s.SerializeObject<RequestOptions.ErrorPopupOptions>(errorRetryPopup, name: "errorRetryPopup");
			successPopup = s.SerializeObject<RequestOptions.PopupOptions>(successPopup, name: "successPopup");
			silentConnection = s.Serialize<bool>(silentConnection, name: "silentConnection");
			needPid = s.Serialize<bool>(needPid, name: "needPid");
			timeout = s.Serialize<float>(timeout, name: "timeout");
		}
		[Games(GameFlags.RA)]
		public partial class PopupOptions : CSerializable {
			public bool show;
			public Enum_trcContext trcContext;
			public float delay;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				show = s.Serialize<bool>(show, name: "show");
				trcContext = s.Serialize<Enum_trcContext>(trcContext, name: "trcContext");
				delay = s.Serialize<float>(delay, name: "delay");
			}
			public enum Enum_trcContext {
			}
		}
		[Games(GameFlags.RA)]
		public partial class ErrorPopupOptions : CSerializable {
			public RequestOptions.PopupOptions _default;
			public CMap<Error.GameServerError, RequestOptions.PopupOptions> specific;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				_default = s.SerializeObject<RequestOptions.PopupOptions>(_default, name: "default");
				specific = s.SerializeObject<CMap<Error.GameServerError, RequestOptions.PopupOptions>>(specific, name: "specific");
			}
		}
	}
}

