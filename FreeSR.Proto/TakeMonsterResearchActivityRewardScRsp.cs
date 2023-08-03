namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeMonsterResearchActivityRewardScRsp
	{
		[ProtoMember(5)] public ItemList Reward;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(6)] public int FOKMEGBNANB;
	}
	
}
