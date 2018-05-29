using System;

public class Rate
{
    public double k_compHealth = 0;
    public double k_compProp = 0;
    public double k_compEnv = 0;
    public double k_costs = 0;
    public const double k1 = 1.5;
    public const double k2 = 1.15;
    public double k3 = 1;
    public double k4 = 1;
    public const double k5 = 1.15;
    public double k6 = 1;
    public double k7 = 1;
    public double k8 = 1;
    public double k9 = 1;
    public double k10 = 1;
    public double k11 = 1;
    public double k12 = 1;
    public double k13 = 1;
    public double k14 = 1;
    public double k15 = 1;
    public double k16 = 1;
    public double k17 = 1;
    public double k18 = 1;
    public double k19 = 1;
    public double k20 = 1;
    public bool insuranceType;
    public bool defenceType0;
    public void Change(ref double k, double value = -1)
    {
        if (value = -1)
            k = Double.Parse(Console.ReadLine());
        else
            k = value;
    }
    public double Building()
    {
        double price;
        price = ((k_compHealth * k2 + k_compProp * k1) * k3 + k_compEnv) *k4 * k6 * k8 * k9 * k10 * k11 * k12 * k13 * k14 * k15 * k16 * k17 * k18 * k19 * k20;
        return price;
	}
    public double Ingeneering()
    {
        double price;
        price = ((k_compHealth * k2 + k_compProp * k1 * k5) * k3 + k_compEnv) * k4 * k6 * k8 * k9 * k10 * k11 * k12 * k13 * k14 * k15 * k16 * k17 * k18 * k19 * k20;
        return price;
    }
    public void DefenceType(ref double k, bool type = 0)
    {
        if (type == 0)
            k = 0.02;
        else
            k = 0.08;
    }
    public double InsurancePrice(bool type)
    {
        if (type == 0)
            return Building();
        else
            return Ingeneering();
    }
    public double CostsPriceA()
    {
        DefenceType(ref k_costs);
        double price;
        double insurancePrice = InsurancePrice(insuranceType);
        double costsPrice = k_costs * k7 * k8 * k9 * k10 * k11 * k12 * k13 * k14 * k15 * k16 * k17 * k18 * k19 * k20;
        price = insurancePrice + costsPrice;
        return price;
    }
    public double CostsPriceB()
    {
        DefenceType(ref k_costs, defenceType);
        double price;
        double insurancePrice = InsurancePrice(insuranceType);
        double costsPrice = k_costs * k8 * k9 * k10 * k11 * k12 * k13 * k14 * k15 * k16 * k17 * k18 * k19 * k20;
        price = insurancePrice + costsPrice;
        return price;
    }
}
