namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetHeadIconScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(9)] public int CurrentHeadIconId;
	}
	
}
