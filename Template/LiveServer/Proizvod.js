export class Proizvod{
    constructor (id,sifra,naziv,kolicina,velicina,cena){
    this.id=id;
    this.sifra=sifra;
    this.naziv=naziv;
    this.kolicina=kolicina;
    this.velicina=velicina;
    this.cena=cena;
    this.manjikontejner=null;
    this.manjikontejner1=null;

    }
    crtajProizvod(host)
    {
        var divZaPrikazProizvoda=document.createElement("div");
        host.appendChild(divZaPrikazProizvoda);
        this.manjikontejner=divZaPrikazProizvoda;

        var divZaPrikazProizvoda1=document.createElement("div");
        divZaPrikazProizvoda.appendChild(divZaPrikazProizvoda1);
        divZaPrikazProizvoda1.className="divZaPrikazProizvoda";
        divZaPrikazProizvoda1.innerHTML=this.naziv+" Kolicina: "+this.kolicina+" Velicina: "+this.velicina+" Cena: "+this.cena;
        this.manjikontejner1=divZaPrikazProizvoda1;

        var img1 = document.createElement("img");
            this.manjikontejner.appendChild(img1);
            img1.src = this.naziv;///naravno treba poseban atribut za sliku(urlSlike)
        var dugmeKupovina=document.createElement("button");
        dugmeKupovina.innerHTML="kupi";
        this.manjikontejner.appendChild(dugmeKupovina);

        dugmeKupovina.onclick=(ev)=>{
        fetch("https://localhost:5001/Ispit/Kupovina/" + this.id,
        {
            method: "PUT",
            headers: {
                "Content-Type": "application/json"
            },
        }).then(p => {
            if (p.ok) {
                p.json().then(data=>{
                    this.manjikontejner1.innerHTML=data.naziv+" "+" Kolicina: "+data.kolicina+" Velicina: "+data.velicina+" Cena: "+data.cena;
                    
                })

                alert("Uspesna kupovina");
               
            }
            else{
                
                alert("Neuspesna kupovina");
                this.manjikontejner.style.display="none";

            }
        })
    }
}
}