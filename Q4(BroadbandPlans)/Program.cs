namespace Q4_BroadbandPlans_
{
    interface IBroadbandPlan
    {
        int GetBroadbandPlanAmount();
    }
    class Black : IBroadbandPlan
    {
        private readonly bool _isSubscriptionValid;
        private readonly int _discountPercentage;
        private const int PlanAmount = 3000;

        public Black(bool isSubscriptionValid, int discountPercentage)
        {
            _isSubscriptionValid = isSubscriptionValid;
            _discountPercentage = discountPercentage;
        }

        public int GetBroadbandPlanAmount()
        {
            if (_isSubscriptionValid)
            {
                return PlanAmount - (PlanAmount * _discountPercentage / 100);
            }
            return PlanAmount;
        }
    }
    class Gold : IBroadbandPlan
    {
        private readonly bool _isSubscriptionValid;
        private readonly int _discountPercentage;
        private const int PlanAmount = 1500;

        public Gold(bool isSubscriptionValid, int discountPercentage)
        {
            _isSubscriptionValid = isSubscriptionValid;
            _discountPercentage = discountPercentage;
        }

        public int GetBroadbandPlanAmount()
        {
            if (_isSubscriptionValid)
            {
                return PlanAmount - (PlanAmount * _discountPercentage / 100);
            }
            return PlanAmount;
        }
    }
    class SubscribePlan
    {
        private readonly IList<IBroadbandPlan> _broadbandPlans;

        public SubscribePlan(IList<IBroadbandPlan> broadbandPlans)
        {
            _broadbandPlans = broadbandPlans;
        }

        public IList<Tuple<string, int>> GetSubscriptionPlan()
        {
            var result = new List<Tuple<string, int>>();

            foreach (var plan in _broadbandPlans)
            {
                var planType = plan.GetType().Name;
                var amount = plan.GetBroadbandPlanAmount();
                result.Add(Tuple.Create(planType, amount));
            }

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var plans = new List<IBroadbandPlan>
            {
                new Black(true, 50),
                new Black(false, 10),
                new Gold(true, 30),
                new Black(true, 20),
                new Gold(false, 20)
            };

            var subscriptionPlans = new SubscribePlan(plans);
            var result = subscriptionPlans.GetSubscriptionPlan();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Item1}, {item.Item2}");
            }

        }
    }
}
