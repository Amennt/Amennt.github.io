var check = 'I am working!';

console.log(check);

const tl = gsap.timeline({defaults: {ease: "power1.out"}});

tl.to(".text", { y:"0%" , duration: 1, stagger: 0.5 });
tl.to(".slider", {y:"-100%", duration: 1.25, delay: 0.5});
tl.to(".intro", {y:"-100%", duration: 1}, "-=1" )
tl.fromTo("nav", {opacity: "0%"}, {opacity: "100%", duration: 1}, "-=0.5")