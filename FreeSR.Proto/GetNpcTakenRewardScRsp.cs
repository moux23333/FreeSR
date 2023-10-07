namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetNpcTakenRewardScRsp
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(4)] public List<int> Oabgidhgghi;
		[ProtoMember(2)] public int NpcId;
	}

}
