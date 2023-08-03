namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SwitchLineupIndexScRsp
	{
		[ProtoMember(15)] public int Index;
		[ProtoMember(9)] public int Retcode;
	}
	
}
