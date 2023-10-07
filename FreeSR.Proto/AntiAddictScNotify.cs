namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AntiAddictScNotify
	{
		[ProtoMember(9)] public string Msg;
		[ProtoMember(3)] public int MsgType;
		[ProtoMember(8)] public string Level;
	}

}
