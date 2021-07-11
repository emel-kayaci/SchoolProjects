
public class Zambak {

    private double çanakUz;
    private double çanakGen;
    private double taçUz;
    private double taçGen;
    private String tür;
   
    public Zambak(double çanakUz, double çanakGen, double taçUz, double taçGen, String tür) {
        this(çanakUz, çanakGen, taçUz, taçGen);
        this.tür = tür;
    }

    public Zambak(double çanakUz, double çanakGen, double taçUz, double taçGen) {
        this.çanakUz = çanakUz;
        this.çanakGen = çanakGen;
        this.taçUz = taçUz;
        this.taçGen = taçGen;
    }

    public Zambak() {

    }

    @Override
    public String toString() {
        return "Çanak yaprak uzunluğu: " + çanakUz
                + "\nÇanak yaprak genişliği: " + çanakGen
                + "\nTaç yaprak uzunluğu: " + taçUz
                + "\nTaç yaprak genişliği: " + taçGen
                + "\nTür:" + tür;
    }

    public double getÇanakUz() {
        return çanakUz;
    }

    public void setÇanakUz(double çanakUz) {
        this.çanakUz = çanakUz;
    }

    public double getÇanakGen() {
        return çanakGen;
    }

    public void setÇanakGen(double çanakGen) {
        this.çanakGen = çanakGen;
    }

    public double getTaçUz() {
        return taçUz;
    }

    public void setTaçUz(double taçUz) {
        this.taçUz = taçUz;
    }

    public double getTaçGen() {
        return taçGen;
    }

    public void setTaçGen(double taçGen) {
        this.taçGen = taçGen;
    }

    public String getTür() {
        return tür;
    }

    public void setTür(String tür) {
        this.tür = tür;
    }

}
