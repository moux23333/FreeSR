namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AntiAddictScNotify
	{
		[ProtoMember(4)] public string Msg;
		[ProtoMember(6)] public int MsgType;
		[ProtoMember(7)] public string Level;
	}
	
}
