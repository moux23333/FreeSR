namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishFirstTalkNpcScRsp
	{
		[ProtoMember(6)] public int SeriesId;
		[ProtoMember(8)] public int Retcode;
	}
	
}
