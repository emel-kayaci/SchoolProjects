import re
import tkinter as tk
import numpy as np
import skimage.exposure as skie
import skimage.transform as skit

import cv2

import matplotlib.pyplot as plt
from matplotlib.backends.backend_tkagg import FigureCanvasTkAgg, NavigationToolbar2Tk
from matplotlib.figure import Figure

from scipy import ndimage as ndi
from skimage import filters, io, morphology, img_as_bool, color
from tkinter import ttk, Frame, filedialog
from tkinter.messagebox import showerror
from ctypes import windll


# PIL versiyon uyuşmazlığından dolayı yüklenmeyebilir. PIL yerine PIL'den fork edilmiş Pillow'da kullanılabilir.
import PIL
from PIL import ImageTk, Image, ImageOps

windll.shcore.SetProcessDpiAwareness(1)  # Ekran çözünürlüğü yükseltildi

root = tk.Tk()
root.title('Görüntü İşleme Proje 1')
root.iconbitmap("image.ico")
root.geometry('900x1000')

mainFrame = tk.LabelFrame(root, text='Ana Resim', width=350, height=350)
mainFrame.place(x=50, y=50)

processedFrame = tk.LabelFrame(root, text='İşlenmiş Resim', width=350, height=350)
processedFrame.place(x=500, y=50)

loadButton = tk.Button(root, text='Resim Yükle', width=20, command=lambda: upload_image())
loadButton.place(x=140, y=425)

saveButton = tk.Button(root, text='Resmi Kaydet', width=20, command=lambda: save_image())
saveButton.place(x=590, y=425)


def upload_image():
    for widget in mainFrame.winfo_children():  # Önceki resmi silmek için kullanılır.
        widget.destroy()

    global loaded_image  # Fonksiyon sona erdikten sonra resmin ekranda görüntülenebilmesi için global tanımlanmalıdır.
    global image
    root.filename = filedialog.askopenfilename(initialdir='/', title='Select File',
                                               filetypes=(('png files', '.png'),
                                                          ('jpeg files', '.jpg'),
                                                          ("all files", "*.*")))
    try:
        image = Image.open(root.filename).resize((345, 325))
        loaded_image = ImageTk.PhotoImage(image)
    except PIL.UnidentifiedImageError:
        showerror('Hata!', 'Resim formatına uygun dosya seçimi yapınız.')
    else:
        mainImage = tk.Label(mainFrame, image=loaded_image)
        mainImage.pack()


style = ttk.Style(root)
style.configure('lefttab.TNotebook', tabposition='wn')
notebook = ttk.Notebook(root, style='lefttab.TNotebook', width=565, height=350)
style.theme_settings(style.theme_use(), {"TNotebook.Tab": {"configure": {"padding": 25}}})

# Pencerelerin oluşturulması

goruntuIyilestirme = Frame(notebook, width=400, height=200)
histogramGoruntuleme = Frame(notebook, width=400, height=200)
uzaysalDonusum = Frame(notebook, width=400, height=200)
yogunlukDonusum = Frame(notebook, width=400, height=200)
morfolojik = Frame(notebook, width=400, height=200)
videoIsleme = Frame(notebook, width=400, height=200)

# Oluşturulan pencerelerin ekrana eklenmesi

notebook.add(goruntuIyilestirme, text=' Görüntü İyileştirme İşlemleri ')
notebook.add(histogramGoruntuleme, text='    Histogram Görüntüleme    ')
notebook.add(uzaysalDonusum, text='  Uzaysal Dönüşüm İşlemleri  ')
notebook.add(yogunlukDonusum, text=' Yoğunluk Dönüşüm İşlemleri ')
notebook.add(morfolojik, text='         Morfolojik İşlemler         ')
notebook.add(videoIsleme, text='              Video İşleme              ')
notebook.place(x=50, y=500)

# Girdilerin yalnızca float formatında olmasını kontrol eder.

def validate(string):
    regex = re.compile(r"^[0-9.]*$")
    result = regex.match(string)
    return (string == ""
            or (string.count('.') <= 1
                and result is not None
                and result.group(0) != ""))

def on_validate(p):
    return validate(p)

# Önceki resmi silmek için kullanılır.
def resmi_temizle():
    for widget in processedFrame.winfo_children():
        widget.destroy()

# GÖRÜNTÜ İYİLEŞTİRME VE FİLTRELER

buttonPrewitt = tk.Button(goruntuIyilestirme, text="Prewitt filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("prewitt_v")).place(x=80, y=25)
buttonHessian = tk.Button(goruntuIyilestirme, text="Hessian filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("hessian")).place(x=80, y=69)
buttonGaussian = tk.Button(goruntuIyilestirme, text="Gaussian filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("gaussian")).place(x=80, y=109)
buttonSato = tk.Button(goruntuIyilestirme, text="Sato filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("sato")).place(x=80, y=149)
buttonMeijering = tk.Button(goruntuIyilestirme, text="Meijering filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("meijering")).place(x=80, y=189)

buttonSobel = tk.Button(goruntuIyilestirme, text="Sobel filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("sobel")).place(x=80, y=229)
buttonUnsharpMask = tk.Button(goruntuIyilestirme, text="Unsharp mask filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("unsharp_mask")).place(x=80, y=269)
buttonLaplacian = tk.Button(goruntuIyilestirme, text="Laplacian filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("laplacian")).place(x=80, y=309)
buttonBilateral = tk.Button(goruntuIyilestirme, text="Bilateral filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("bilateral")).place(x=80, y=349)
buttonScharr = tk.Button(goruntuIyilestirme, text="Scharr filtresini uygula.", width=50, height=1, command=lambda: goruntu_iyilestirme_yap("scharr")).place(x=80, y=389)

def goruntu_iyilestirme_yap(islem_adi):
    global processed_image
    resmi_temizle()
    try:
        img_gray = ImageOps.grayscale(image)
        if islem_adi == "prewitt_v":
            processed_image_array = filters.prewitt_v(np.array(img_gray))
        elif islem_adi == "hessian":
            processed_image_array = filters.hessian(np.array(img_gray))
        elif islem_adi == "gaussian":
            processed_image_array = filters.gaussian(np.array(img_gray))
        elif islem_adi == "sato":
            processed_image_array = filters.sato(np.array(img_gray))
        elif islem_adi == "meijering":
            processed_image_array = filters.meijering(np.array(img_gray))
        elif islem_adi == "sobel":
            processed_image_array = ndi.sobel(np.array(img_gray))
        elif islem_adi == "unsharp_mask":
            processed_image_array = filters.unsharp_mask(np.array(img_gray))
        elif islem_adi == "laplacian":
            processed_image_array = cv2.Laplacian(np.array(img_gray), cv2.CV_64F)
        elif islem_adi == "bilateral":
            processed_image_array = cv2.bilateralFilter(np.array(img_gray), 9, 75, 75)
        else:
            processed_image_array = filters.scharr(np.array(img_gray))
    except NameError:
        showerror('Hata!', 'İşlem yapabilmek için resim yükleyiniz.')
    else:
        processed_image = Image.fromarray((processed_image_array * 255).astype(np.uint8))
        show_processed_image(processed_image)

# MORFOLOJIK ISLEMLER

buttonDilation = tk.Button(morfolojik, text="Dilation işlemini uygula.", width=50, height=1, command=lambda: morfolojik_islem_yap("Dilation")).place(x=80, y=25)
buttonErosion = tk.Button(morfolojik, text="Erosion işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("Erosion")).place(x=80, y=69)
buttonSkeletonize = tk.Button(morfolojik, text="Skeletonize işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("Skeletonize")).place(x=80, y=109)
buttonThin = tk.Button(morfolojik, text="Thinning işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("Thinning")).place(x=80, y=149)
buttonROS = tk.Button(morfolojik, text="Küçük objeleri kaldır işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("RSO")).place(x=80, y=189)
buttonTopHat = tk.Button(morfolojik, text="TopHat işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("TopHat")).place(x=80, y=229)
buttonHitMiss = tk.Button(morfolojik, text="Opening işlemini uygula.", width=50, height=1, command=lambda: morfolojik_islem_yap("Opening")).place(x=80, y=269)
buttonThick = tk.Button(morfolojik, text="Closing işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("Closing")).place(x=80, y=309)
buttonGradient = tk.Button(morfolojik, text="Morph Gradient işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("MorphGrad")).place(x=80, y=349)
buttonBlackHat = tk.Button(morfolojik, text="BlackHat işlemini uygula.", width=50, height=1, command=lambda:  morfolojik_islem_yap("BlackHat")).place(x=80, y=389)

def morfolojik_islem_yap(islem_adi):
    from scipy.ndimage.morphology import binary_erosion, binary_dilation, grey_erosion
    from skimage.morphology import erosion, dilation
    global processed_image
    resmi_temizle()
    processed_image_array = []
    try:
        kernel = np.ones((20, 20), np.uint8)
        img_gray = ImageOps.grayscale(image)
        if islem_adi == "Dilation":
            processed_image_array = dilation(np.array(img_gray), kernel)
        elif islem_adi == "Erosion":
            for i in range(10):
                processed_image_array = erosion(np.array(img_gray), kernel)
        elif islem_adi == "Skeletonize":
            img = img_as_bool(color.rgb2gray(np.asarray(image)))
            out = morphology.medial_axis(img)
            processed_image_array = np.array(out)*255
        elif islem_adi == "Thinning":
            processed_image_array = morphology.thin(img_gray, 25)*255
        elif islem_adi == "Closing":
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (10, 10))
            processed_image_array = cv2.morphologyEx(np.array(img_gray), cv2.MORPH_CLOSE, kernel)
        elif islem_adi == "TopHat":
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (3, 3))
            processed_image_array = cv2.morphologyEx(np.array(img_gray), cv2.MORPH_TOPHAT, kernel)
        elif islem_adi == "Opening":
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (10, 10))
            processed_image_array = cv2.morphologyEx(np.array(img_gray), cv2.MORPH_OPEN, kernel)
        elif islem_adi == "RSO":
            processed_image_array = morphology.remove_small_objects(np.array(img_gray), 50)
        elif islem_adi == "MorphGrad":
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (3, 3))
            processed_image_array = cv2.morphologyEx(np.array(img_gray), cv2.MORPH_GRADIENT, kernel)
        elif islem_adi == "BlackHat":
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (5, 5))
            processed_image_array = cv2.morphologyEx(np.array(img_gray), cv2.MORPH_BLACKHAT, kernel)
    except NameError:
        showerror('Hata!', 'İşlem yapabilmek için resim yükleyiniz.')
    else:
        processed_image = Image.fromarray((processed_image_array).astype(np.uint8))
        show_processed_image(processed_image)


# UZAYSAL DÖNÜŞÜM İŞLEMLERİ

tk.Label(uzaysalDonusum, text="1. Rotate İşlemi").place(x=120, y=60)
buttonRotateLeft = tk.Button(uzaysalDonusum, text="<--", width=5, height=1, command=lambda: uzaysal_donusum_yap("sola_dondur")).place(x=300, y=55)
buttonRotateRight = tk.Button(uzaysalDonusum, text="-->", width=5, height=1, command=lambda: uzaysal_donusum_yap("saga_dondur")).place(x=400, y=55)

tk.Label(uzaysalDonusum, text="2. Swirl İşlemi").place(x=120, y=120)
buttonSwirl = tk.Button(uzaysalDonusum, text="Uygula", width=5, height=1, command=lambda: uzaysal_donusum_yap("swirl")).place(x=400, y=115)

tk.Label(uzaysalDonusum, text="3. Rescale İşlemi (0-1):").place(x=120, y=180)
textBoxolcek = tk.Entry(uzaysalDonusum, validate="key")
textBoxolcek.config(validatecommand=(textBoxolcek.register(on_validate), '%P'))
textBoxolcek.place(x=300, y=180, width=50)
buttonRescale = tk.Button(uzaysalDonusum, text="Uygula", width=5, height=1, command=lambda: uzaysal_donusum_yap("rescale")).place(x=400, y=175)

tk.Label(uzaysalDonusum, text="4. Warp Polar İşlemi").place(x=120, y=240)
buttonWarpPolar = tk.Button(uzaysalDonusum, text="Uygula", width=5, height=1, command=lambda: uzaysal_donusum_yap("warp_polar")).place(x=400, y=235)

tk.Label(uzaysalDonusum, text="5. Resize İşlemi (Boy/En):").place(x=120, y=300)

textBoxEn = tk.Entry(uzaysalDonusum, validate="key")
textBoxEn.config(validatecommand=(textBoxEn.register(on_validate), '%P'))
textBoxEn.place(x=300, y=300, width=50)

textBoxBoy = tk.Entry(uzaysalDonusum, validate="key")
textBoxBoy.config(validatecommand=(textBoxBoy.register(on_validate), '%P'))
textBoxBoy.place(x=300, y=330, width=50)

buttonResize = tk.Button(uzaysalDonusum, text="Uygula", width=5, height=1, command=lambda: uzaysal_donusum_yap("resize")).place(x=400, y=295)

# Rotate işlemi için sayaç oluşturuldu
class Counter:
    def __init__(self):  # ilk başlatıldığında sayacı sıfıra ayarlar
        self.count = 0

    def increase(self):
        self.count += 1

    def decrease(self):
        self.count -= 1

counter = Counter()

def uzaysal_donusum_yap(islem_adi):
    global processed_image
    resmi_temizle()
    try:
        processed_image_array = []
        if islem_adi == "sola_dondur":
            counter.increase()
            processed_image = image.rotate(45 * counter.count)
        elif islem_adi == "saga_dondur":
            counter.decrease()
            processed_image = image.rotate(45 * counter.count)
        elif islem_adi == "swirl":
            processed_image_array = skit.swirl(np.array(image), strength=50)
        elif islem_adi == "rescale":
            processed_image_array = skit.rescale(np.array(image), float(textBoxolcek.get()), multichannel=True)
        elif islem_adi == "warp_polar":
            processed_image_array = skit.warp_polar(np.array(image), output_shape=(325, 325), multichannel=True)
        else:
            processed_image_array = skit.resize(np.array(image), (int(textBoxEn.get()), int(textBoxBoy.get())))
    except NameError:
        showerror('Hata!', 'İşlem yapabilmek için resim yükleyiniz.')
    else:
        if islem_adi != "sola_dondur" and islem_adi != "saga_dondur":
            processed_image = Image.fromarray((processed_image_array * 255).astype(np.uint8))
        show_processed_image(processed_image)

# HISTOGRAM ISLEMLERI
buttonHist = tk.Button(histogramGoruntuleme, text="Histogram", width=9, height=1, command=lambda: hist_equalize()).place(x=480, y=15)

def hist_equalize():
    global processed_image
    resmi_temizle()
    try:
        img_gray = ImageOps.grayscale(image)
        processed_image_array = cv2.equalizeHist(np.array(img_gray))
        hist_show()
    except NameError:
        showerror('Hata!', 'İşlem yapabilmek için resim yükleyiniz.')
    else:
        processed_image = Image.fromarray((processed_image_array * 255).astype(np.uint8))
        show_processed_image(processed_image)
        # işlenmiş görüntünün histogramı
        hist_processed = cv2.calcHist([np.array(processed_image)], [0], None, [256], [0, 256])
        plt.plot(hist_processed)
        plt.show()


def hist_show():
    fig = Figure(figsize=(4, 4), dpi=100)
    canvas = FigureCanvasTkAgg(fig, histogramGoruntuleme)

    img_gray = ImageOps.grayscale(image)
    histr = cv2.calcHist([np.array(img_gray)], [0], None, [256], [0, 256])

    # histogram grafiginin cizdirilmesi ve GUI'ye entegre edilmesi
    hist_plot = fig.add_subplot(111)
    hist_plot.plot(histr)
    hist_plot.set_title("Histogram Grafiği")

    canvas.draw()
    canvas.get_tk_widget().pack(side=tk.LEFT)

    # histogram grafigine toolbar eklenmesi
    toolbar = NavigationToolbar2Tk(canvas, histogramGoruntuleme)
    toolbar.update()
    canvas.get_tk_widget().pack(side=tk.TOP)


# YOĞUNLUK DÖNÜŞÜM İŞLEMİ

tk.Label(yogunlukDonusum, text="Minimum in range değeri:").place(x=120, y=60)
textboxInRange1 = tk.Entry(yogunlukDonusum, validate="key")
textboxInRange1.config(validatecommand=(textboxInRange1.register(on_validate), '%P'))
textboxInRange1.place(x=320, y=60)

tk.Label(yogunlukDonusum, text="Maximum in range değeri:").place(x=120, y=120)
textboxInRange2 = tk.Entry(yogunlukDonusum, validate="key")
textboxInRange2.config(validatecommand=(textboxInRange2.register(on_validate), '%P'))
textboxInRange2.place(x=320, y=120)

labelOutRange1 = tk.Label(yogunlukDonusum, text="Minimum out range değeri:").place(x=120, y=180)
textboxOutRange1 = tk.Entry(yogunlukDonusum, validate="key")
textboxOutRange1.config(validatecommand=(textboxOutRange1.register(on_validate), '%P'))
textboxOutRange1.place(x=320, y=180)

labelOutRange2 = tk.Label(yogunlukDonusum, text="Maximum out range değeri:").place(x=120, y=240)
textboxOutRange2 = tk.Entry(yogunlukDonusum, validate="key")
textboxOutRange2.config(validatecommand=(textboxOutRange2.register(on_validate), '%P'))
textboxOutRange2.place(x=320, y=240)

tk.Button(yogunlukDonusum, text="Giriş", width=9, height=1, command=lambda: yogunluk_donustur()).place(x=320, y=300)

def yogunluk_donustur():
    resmi_temizle()

    global processed_image
    minInRange = textboxInRange1.get()
    maxInRange = textboxInRange2.get()
    minOutRange = textboxOutRange1.get()
    maxOutRange = textboxOutRange2.get()

    try:
        processed_image_array = skie.rescale_intensity(image, in_range=(float(minInRange), float(maxInRange)), out_range=(float(minOutRange), float(maxOutRange)))
    except NameError:
        showerror('Hata!', 'İşlem yapabilmek için resim yükleyiniz.')
    except ValueError:
        showerror('Hata', 'Resmin işlenebilmesi için parametre değerlerini giriniz.')
    else:
        processed_image = Image.fromarray((processed_image_array * 255).astype(np.uint8))
        show_processed_image(processed_image)

# VİDEO İŞLEME
tk.Label(videoIsleme, text="Canny ile kenar belirlenmesi\nUygulamadan çıkmak için ESC tuşuna basınız.").place(x=130, y=80)
tk.Button(videoIsleme, text="Çalıştırmak için tıklayınız.", command=lambda: video_processing()).place(x=200, y=180)

def show_processed_image(img):
    tkImage = ImageTk.PhotoImage(image=img)
    imgLabel = tk.Label(processedFrame, image=tkImage)
    imgLabel.image = tkImage  # Garbage collector yüzünden silinmemesi için ek referans oluşturulmalıdır.
    imgLabel.pack()

def save_image():
    if 'processed_image' not in globals():
        showerror('Hata!', 'Resmi kaydetmek için işleyiniz.')
    else:
        rgb_im = processed_image.convert('RGB')  # Png uzantılı dosyalar RGBA tipindedir. Jpg tipinde kaydedebilmek için alpha kanalını yok etmek gerekir.
        filename = filedialog.asksaveasfile(mode='w', defaultextension=".jpg")
        if not filename:
            return
        rgb_im.save(filename)

def video_processing():

    cap = cv2.VideoCapture('toyota.mp4')
    while 1:
        ret, frame = cap.read()
        if ret:
            cv2.imshow('Video', frame)

        edges = cv2.Canny(frame, 100, 100)
        cv2.imshow('Edges', edges)

        # En az 1 milisaniye beklendiyse ve esc tuşuna basılırsa video işlem sonlanır
        if cv2.waitKey(1) & 0XFF == 27:
            break

    cap.release()
    cv2.destroyAllWindows()


root.mainloop()
