namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishCurTurnScRsp
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(13)] public int HLEFBLMBGEA;
	}
	
}
